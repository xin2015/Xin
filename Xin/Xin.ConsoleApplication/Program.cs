using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xin.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = CryptogramHelper.EncryptByMD5("123456");
        }
    }
}
