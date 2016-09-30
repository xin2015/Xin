using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xin
{
    public class MD5Helper
    {
        public static string Encrypt(string text)
        {
            MD5 md5 = MD5.Create();
            return Convert.ToBase64String(md5.ComputeHash(Encoding.Default.GetBytes(text)));
        }
    }
}
