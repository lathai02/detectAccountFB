using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DetectAccountFB
{
    public partial class Form1 : Form
    {
        private LicenseKeyGenerator licenseKeyGenerator;
        public Form1()
        {
            InitializeComponent();
            licenseKeyGenerator = new LicenseKeyGenerator();
        }

        private void BtnGenerateKey_Click(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var bios = licenseKeyGenerator.bios + "CJSE8235NCXFX";
                var processorId = licenseKeyGenerator.processorId + "DIZXB2912FYEH";
                var userName = txtDesktopName.Text;
                var licensekey = TxtBoxLicensekey.Text;

                string licenseKeyListApiFomarted = string.Format(Constants.licenseKeyListApi, userName, licensekey, bios, processorId);

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(licenseKeyListApiFomarted);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string deviceName = Environment.MachineName;
                txtDesktopName.Text = deviceName;

                licenseKeyGenerator = new LicenseKeyGenerator();
                licenseKeyGenerator.GetLicenseKey();
                string? key = licenseKeyGenerator.licenseKey;
                TxtBoxLicensekey.Text = key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
