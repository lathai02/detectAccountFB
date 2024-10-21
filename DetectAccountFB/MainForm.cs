using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectAccountFB
{
    public partial class MainForm : Form
    {
        BindingSource source;
        private List<Account> accounts;
        int maxThreads = 1;
        private static ConcurrentQueue<string> logQueue;
        private static bool isWriting;


        public MainForm()
        {
            InitializeComponent();

            logQueue = new ConcurrentQueue<string>();
            isWriting = false; ;

            txtNumberOfThreads.Text = "1";
            this.WindowState = FormWindowState.Maximized;
            dataGridViewListAccount.Height = 880;
            dataGridViewListAccount.Width = 1920;

            dataGridViewListAccount.MouseDown += DataGridViewListAccount_MouseDown;
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridViewListAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListAccount.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng
                string username = selectedRow.Cells["Uid"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();

                // Chuẩn bị chuỗi để copy
                string copyText = $"{username}|{password}";

                // Sao chép vào clipboard
                Clipboard.SetText(copyText);
            }
        }

        private void DataGridViewListAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Lấy vị trí chuột
                var hitTest = dataGridViewListAccount.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0) // Nếu nhấp vào hàng
                {
                    dataGridViewListAccount.ClearSelection(); // Xóa lựa chọn cũ
                    dataGridViewListAccount.Rows[hitTest.RowIndex].Selected = true; // Chọn hàng
                    contextMenuStrip1.Show(dataGridViewListAccount, e.Location); // Hiện menu ngữ cảnh
                }
            }
        }

        private void LoadListAccount()
        {
            try
            {
                source = new BindingSource();
                dataGridViewListAccount.DataSource = null;
                dataGridViewListAccount.Columns.Clear();
                dataGridViewListAccount.AllowUserToAddRows = false;
                dataGridViewListAccount.DataSource = source;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "Choose";
                checkBoxColumn.HeaderText = "Choose";
                checkBoxColumn.Width = 50;
                checkBoxColumn.ReadOnly = false;
                dataGridViewListAccount.Columns.Add(checkBoxColumn);

                dataGridViewListAccount.Columns.Add("Number", "Number");

                source.DataSource = accounts;

                for (int i = 0; i < dataGridViewListAccount.Rows.Count; i++)
                {
                    dataGridViewListAccount.Rows[i].Cells["Number"].Value = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                maxThreads = int.Parse(txtNumberOfThreads.Text); 
                maxThreads = Math.Min(maxThreads, Environment.ProcessorCount);

                var listAccount = await GetFile();
                MessageBox.Show("Đã đọc xong file");
                LoadListAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<List<Account>> GetFile()
        {
            string? filePath = null;
            accounts = new List<Account>();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn một tệp tin";
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                // Đọc các dòng từ tệp một cách bất đồng bộ
                string[] lines = await File.ReadAllLinesAsync(filePath);

                var options = new ParallelOptions
                {
                    MaxDegreeOfParallelism = maxThreads
                };

                Parallel.For(0, lines.Length, options, i =>
                {
                    if (lines[i].Contains(":"))
                    {
                        string[] parts = lines[i].Split(':');
                        if (parts.Length == 2)
                        {
                            string username = parts[0].Trim();
                            string password = parts[1].Trim();

                            Account a = new Account
                            {
                                Uid = username,
                                Password = password
                            };

                            lock (accounts)
                            {
                                accounts.Add(a);
                            }
                        }
                        else
                        {
                            WriteLog($"line không đúng format thiếu uid hoặc password ở dòng {i + 1}");
                        }
                    }
                    else
                    {
                        WriteLog($"file không đúng format không chứa dấu : ở dòng {i + 1}");
                    }
                });
            }
            return accounts;
        }

        private void WriteLog(string message)
        {
            string filePath = Path.Combine(Application.StartupPath, "log.txt");
            logQueue.Enqueue($"{DateTime.Now}: {message}");
            WriteLogFromQueue(filePath);
        }

        private async void WriteLogFromQueue(string filePath)
        {
            if (isWriting) return; // Nếu đang ghi log thì không làm gì cả

            isWriting = true; // Đánh dấu trạng thái là đang ghi log

            try
            {
                while (logQueue.TryDequeue(out string? logMessage))
                {
                    // Ghi log vào file một cách bất đồng bộ
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        await writer.WriteLineAsync(logMessage);
                    }
                }
            }
            finally
            {
                isWriting = false; // Sau khi ghi xong, đặt lại cờ để cho phép ghi log tiếp theo
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
