using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin
{
    public static class ByteExtension
    {
        public static string ToBase64String(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }

        public static string ToUTF8String(this byte[] array)
        {
            return Encoding.UTF8.GetString(array);
        }
    }
}
