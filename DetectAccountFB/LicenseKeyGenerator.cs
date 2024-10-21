using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.Cryptography;

namespace DetectAccountFB
{
    public class LicenseKeyGenerator
    {
        public string? licenseKey { get; set; }
        public string? bios { get; set; }
        public string? processorId { get; set; }
        public void GetLicenseKey()
        {
            string? hwid = null;

            bios = GetBios() ?? throw new Exception("Không thể lấy BIOS");
            processorId = GetProcessorId() ?? throw new Exception("Không thể lấy BIOS");
            hwid = bios + "-" + processorId;
            licenseKey = GenerateKey(hwid) ?? throw new Exception("Không thể lấy license key");
        }

        private string? GetProcessorId()
        {
            string? processorId = null;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            ManagementObjectCollection info = searcher.Get();
            foreach (ManagementObject obj in info)
            {
                processorId = obj["ProcessorId"].ToString();
                break;
            }
            return processorId;
        }

        private string? GetBios()
        {
            string? bios = null;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");
            ManagementObjectCollection info = searcher.Get();
            foreach (ManagementObject obj in info)
            {
                bios = obj["SerialNumber"].ToString();
                break;
            }
            return bios;
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
