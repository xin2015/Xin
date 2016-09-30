using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123456";
            string b = CryptogramHelper.EncryptByMD5(a);
            string c = CryptogramHelper.EncryptTo32ByMD5(a);
            string d = CryptogramHelper.EncryptBySHA256(a);
            string e = CryptogramHelper.EncryptTo32BySHA256(a);
            int f = e.Length;
        }
    }
}
