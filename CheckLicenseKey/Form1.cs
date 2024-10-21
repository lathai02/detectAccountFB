using System.Security.Cryptography;
using System.Text;

namespace CheckLicenseKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var processorId = txtBoxProcessorId.Text;
                var bios = txtBoxBios.Text;
                var licenseKey = txtBoxLicenseKey.Text;

                var hwid = GenerateHWID(processorId, bios);
                var key = GenerateKey(hwid);

                if (licenseKey == key)
                {
                    MessageBox.Show("✓ License key hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("✗ License key không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateHWID(string processorId, string bios)
        {
            string toRemoveprocessorId = "DIZXB2912FYEH";
            string toRemovebios = "CJSE8235NCXFX"; 

            var processorIdReal = processorId.Replace(toRemoveprocessorId, "").Trim();
            var biosReal = bios.Replace(toRemovebios, "").Trim();

            var hwid = biosReal + "_-" + processorIdReal;

            return hwid;
        }

        private string GenerateKey(string hwid)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(hwid);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Chuyển byte sang hex
                }
                return builder.ToString().Substring(0, 25); // Cắt chỉ lấy 16 ký tự đầu
            }
        }
    }
}
