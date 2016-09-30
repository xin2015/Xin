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
            string a = "ymssn";
            string b = "liuhaixin";
            string c = CryptogramHelper.Encrypt(a, b);
            string d;
            CryptogramHelper.Decrypt(c, b, out d);
        }
    }
}
