using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectAccountFB
{
    public class Account
    {
        public string? Uid { get; set; } = null;
        public string? Password { get; set; } = null;
        public string? ProxyInfo { get; set; }
        public string? Status { get; set; } = null;
    }
}
