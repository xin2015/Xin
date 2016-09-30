using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xin
{
    public class CryptogramHelper : MarshalByRefObject
    {
        private static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        private static SHA256 mySHA256 = SHA256Managed.Create();

        public static bool Decrypt(string encryptedString, string key, out string result)
        {
            try
            {
                var TobeDecrypted = Convert.FromBase64String(encryptedString);
                des.Mode = CipherMode.ECB;
                des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
                var Decrypted = des.CreateDecryptor().TransformFinalBlock(TobeDecrypted, 0, TobeDecrypted.Length);
                des.Clear();
                result = Encoding.UTF8.GetString(Decrypted);
                return true;
            }
            catch
            {
                result = string.Empty;
                return false;
            }
        }

        public static string Encrypt(string originalString, string key)
        {
            byte[] TobeEncrypted = Encoding.UTF8.GetBytes(originalString);
            des.Mode = CipherMode.ECB;
            des.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            var Encrypted = des.CreateEncryptor().TransformFinalBlock(TobeEncrypted, 0, TobeEncrypted.Length);
            des.Clear();
            return Convert.ToBase64String(Encrypted);
        }

        public static string EncryptByMD5(string text)
        {
            return Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(text)));
        }

        public static string EncryptTo32ByMD5(string input)
        {
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string EncryptBySHA256(string text)
        {
            return Convert.ToBase64String(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(text)));
        }

        public static string EncryptTo64BySHA256(string input)
        {
            byte[] data = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
