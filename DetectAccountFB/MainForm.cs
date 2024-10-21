using System;
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


        public MainForm()
        {
            InitializeComponent();
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
                string username = selectedRow.Cells["Username"].Value.ToString();
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

        private void LoadListAccount(List<AccountShow>? listAccount)
        {
            try
            {
                source = new BindingSource();
                dataGridViewListAccount.DataSource = null;
                dataGridViewListAccount.Columns.Clear();
                dataGridViewListAccount.AllowUserToAddRows = false;
                dataGridViewListAccount.DataSource = source;

                // Thêm cột checkbox "Chọn"
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "Choose";
                checkBoxColumn.HeaderText = "Choose";
                checkBoxColumn.Width = 50;
                checkBoxColumn.ReadOnly = false;
                dataGridViewListAccount.Columns.Add(checkBoxColumn);

                dataGridViewListAccount.Columns.Add("Number", "Number");

                source.DataSource = listAccount;

                for (int i = 0; i < dataGridViewListAccount.Rows.Count; i++)
                {
                    dataGridViewListAccount.Rows[i].Cells["Number"].Value = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car List");
            }
        }

        private void buttonImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                var listAccount = GetFile();
                var listAccountShow = GetListAccountShow(listAccount);
                LoadListAccount(listAccountShow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car List");
            }
        }

        private List<AccountShow> GetListAccountShow(List<Account> listAccount)
        {
            List<AccountShow> listAccountShow = new List<AccountShow>();
            foreach (var account in listAccount)
            {
                AccountShow ash = new AccountShow
                {
                    Username = account.Username,
                    Password = account.Password
                };

                listAccountShow.Add(ash);
            }

            return listAccountShow;
        }

        private List<Account> GetFile()
        {
            string? filePath = null;
            List<Account> accounts = new List<Account>();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn một tệp tin";
            openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line.Contains("|"))
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string username = parts[0].Trim();
                            string password = parts[1].Trim();

                            Account a = new Account
                            {
                                Username = username,
                                Password = password
                            };

                            accounts.Add(a);
                        }
                        else
                        {
                            throw new Exception("file không đúng format");
                        }
                    }
                    else
                    {
                        throw new Exception("file không đúng format");
                    }
                }
            }
            return accounts;
        }
    }
}
