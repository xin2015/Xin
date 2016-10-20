using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xin
{
    /// <summary>
    /// 加密解密工具类
    /// </summary>
    public static class CryptogramHelper
    {
        static CryptogramHelper()
        {
            _Aes = Aes.Create();
            _RSACryptoServiceProvider = new RSACryptoServiceProvider();
            _SHA256 = SHA256.Create();
            defaultKey = "Hume2016!@";
            byte[] tdesKey = _SHA256.ComputeHash(Encoding.UTF8.GetBytes(defaultKey));
            byte[] tdesIV = tdesKey.Take(16).ToArray();
            _Aes.Key = tdesKey;
            _Aes.IV = tdesIV;
            publicRSAKey = "BgIAAACkAABSU0ExAAQAAAEAAQAnKEtami2zzISUzbFW0il1htem19ThfZyQqayJtlV4oNHautm3u9rHbfPhqMpTQ/oBYBHHfP3tj9qBmLxePaLlkE8nhYDWpHDKq9KM/zSZjHlsFEhuW/AMCSwBgFzZ/zTe9ulfWcLid/hNClFO3QHs+AJKoqBgMCg6QgMzNqZ+oA==";
            privateRSAKey = "BwIAAACkAABSU0EyAAQAAAEAAQAnKEtami2zzISUzbFW0il1htem19ThfZyQqayJtlV4oNHautm3u9rHbfPhqMpTQ/oBYBHHfP3tj9qBmLxePaLlkE8nhYDWpHDKq9KM/zSZjHlsFEhuW/AMCSwBgFzZ/zTe9ulfWcLid/hNClFO3QHs+AJKoqBgMCg6QgMzNqZ+oMXskcBMGj2lKyFM4Otdfi4gxdBGvNV9rimPEzq2NsWBo7c0uisVtDtANO0ZcUij/XBqJcgn7JudYQ9NbxkVROL7J+59mdVw/pzD23J2F0Ir2DHL0ugj+aYCB6My3JC8Z3LvMkWJZIcmcTQbOJol03CWNEehqClC3oUv5nY47ZW1DQiqWETAhzLQNy2ag2+jXlifgmY9ikOTfI0wfVDduYjaFBtOur+xFWI4v75GANP6FwCNNXcEhjVaZrv9QYfTUP1vSvEVx70pe61L4KFVXCSfYDDnA3eaWbriXUFrhQbw2XzDq1OuiTdE+EjpJu1DFbyIpUmNsoHvQnrY5JmLhzwijruy0ooLK9gikxwVZeyRsDRbSD5062vHqv3iSwqriOQzwn7xuCnq3StuHKlgm8yi5fyfsOXYmI1CnWFG+HF0kXZ1Csd+s4ouzPq/FPQ/nYuVFYuoPzOxLPl2mGUQi7/m5tyQnj/s4fH/kdivKEIclhJrbB04TDjuEGzduyA7WDWiDAx7uSL4AwafVbOz8Vc4qw0FEBrnnYjKwHUEJrTzsiSc4rp3XXSCWrbUEiUyOY/QF//tK6ZBWmhkuIVAYyI=";
            _RSACryptoServiceProvider.ImportCspBlob(publicRSAKey.FromBase64String());
            _RSACryptoServiceProvider.ImportCspBlob(privateRSAKey.FromBase64String());
            decryptCount = _RSACryptoServiceProvider.KeySize / 8;
            encryptCount = decryptCount - 11;
        }

        private static Aes _Aes;
        private static RSACryptoServiceProvider _RSACryptoServiceProvider;
        private static SHA256 _SHA256;
        private static string defaultKey;
        /// <summary>
        /// RSA算法（非对称）加密公钥
        /// </summary>
        public static string publicRSAKey;
        /// <summary>
        /// RSA算法（非对称）解密私钥
        /// </summary>
        private static string privateRSAKey;
        /// <summary>
        /// RSA非对称加密单次加密字符串长度
        /// </summary>
        private static int encryptCount;
        /// <summary>
        /// RSA非对称加密单次解密字符串长度
        /// </summary>
        private static int decryptCount;

        #region SymmetricalEncryption 对称加密
        #region Encrypt
        /// <summary>
        /// 使用Aes进行对称加密
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            return _Aes.CreateEncryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥字节数组</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer, byte[] tdesKey)
        {
            byte[] tdesIV = tdesKey.Take(16).ToArray();
            return Encrypt(inputBuffer, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="key">Aes算法的密钥字符串（UTF8）</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer, string key)
        {
            byte[] tdesKey = _SHA256.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Encrypt(inputBuffer, tdesKey);
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer)
        {
            return _Aes.CreateEncryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用Aes进行对称加密
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string Encrypt(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
            return Encrypt(inputBuffer, tdesKey, tdesIV).ToBase64String();
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <param name="tdesKey">Aes算法的密钥字节数组</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string Encrypt(string inString, byte[] tdesKey)
        {
            byte[] tdesIV = tdesKey.Take(16).ToArray();
            return Encrypt(inString, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <param name="key">Aes算法的密钥字符串（UTF8）</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string Encrypt(string inString, string key)
        {
            byte[] tdesKey = _SHA256.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Encrypt(inString, tdesKey);
        }

        /// <summary>
        /// 使用Aes进行对称加密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string Encrypt(string inString)
        {
            byte[] inputBuffer = inString.FromUTF8String();
            return Encrypt(inputBuffer).ToBase64String();
        }
        #endregion
        #region Decrypt
        /// <summary>
        /// 使用Aes进行对称解密
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            return _Aes.CreateDecryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥字节数组</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer, byte[] tdesKey)
        {
            byte[] tdesIV = tdesKey.Take(16).ToArray();
            return Decrypt(inputBuffer, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="key">Aes算法的密钥字符串（UTF8）</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer, string key)
        {
            byte[] tdesKey = _SHA256.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Decrypt(inputBuffer, tdesKey);
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer)
        {
            return _Aes.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用Aes进行对称解密
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string Decrypt(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = inString.FromBase64String();
            return Decrypt(inputBuffer, tdesKey, tdesIV).ToUTF8String();
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <param name="tdesKey">Aes算法的密钥字节数组</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string Decrypt(string inString, byte[] tdesKey)
        {
            byte[] tdesIV = tdesKey.Take(16).ToArray();
            return Decrypt(inString, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <param name="key">Aes算法的密钥字符串（UTF8）</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string Decrypt(string inString, string key)
        {
            byte[] tdesKey = _SHA256.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Decrypt(inString, tdesKey);
        }

        /// <summary>
        /// 使用Aes进行对称解密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string Decrypt(string inString)
        {
            byte[] inputBuffer = inString.FromBase64String();
            return Decrypt(inputBuffer).ToUTF8String();
        }
        #endregion
        #endregion
        #region AsymmetricEncryption 非对称加密
        #region Encrypt
        /// <summary>
        /// 使用RSA进行非对称加密
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="keyBlob">RSA公钥Blob字节数组</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] AsymmetricEncrypt(byte[] inputBuffer, byte[] keyBlob)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportCspBlob(keyBlob);
                if (inputBuffer.Length <= encryptCount)
                {
                    return RSA.Encrypt(inputBuffer, false);
                }
                else
                {
                    List<byte> list = new List<byte>();
                    while (inputBuffer.Any())
                    {
                        list.AddRange(RSA.Encrypt(inputBuffer.Take(encryptCount).ToArray(), false));
                        inputBuffer = inputBuffer.Skip(encryptCount).ToArray();
                    }
                    return list.ToArray();
                }
            }
        }

        /// <summary>
        /// 使用RSA进行非对称加密
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="keyBlobString">RSA公钥Blob字符串（Base64）</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] AsymmetricEncrypt(byte[] inputBuffer, string keyBlobString)
        {
            byte[] keyBlob = keyBlobString.FromBase64String();
            return AsymmetricEncrypt(inputBuffer, keyBlob);
        }

        /// <summary>
        /// 使用RSA进行非对称加密，使用默认公钥
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] AsymmetricEncrypt(byte[] inputBuffer)
        {
            if (inputBuffer.Length <= encryptCount)
            {
                return _RSACryptoServiceProvider.Encrypt(inputBuffer, false);
            }
            else
            {
                List<byte> list = new List<byte>();
                while (inputBuffer.Any())
                {
                    list.AddRange(_RSACryptoServiceProvider.Encrypt(inputBuffer.Take(encryptCount).ToArray(), false));
                    inputBuffer = inputBuffer.Skip(encryptCount).ToArray();
                }
                return list.ToArray();
            }
        }

        /// <summary>
        /// 使用RSA进行非对称加密
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <param name="keyBlob">RSA公钥Blob字节数组</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string AsymmetricEncrypt(string inString, byte[] keyBlob)
        {
            byte[] inputBuffer = inString.FromUTF8String();
            return AsymmetricEncrypt(inputBuffer, keyBlob).ToBase64String();
        }

        /// <summary>
        /// 使用RSA进行非对称加密
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <param name="keyBlobString">RSA公钥Blob字符串（Base64）</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string AsymmetricEncrypt(string inString, string keyBlobString)
        {
            byte[] keyBlob = keyBlobString.FromBase64String();
            return AsymmetricEncrypt(inString, keyBlob);
        }

        /// <summary>
        /// 使用RSA进行非对称加密，使用默认公钥
        /// </summary>
        /// <param name="inString">待加密的字符串（UTF8）</param>
        /// <returns>加密后的字符串（Base64）</returns>
        public static string AsymmetricEncrypt(string inString)
        {
            byte[] inputBuffer = inString.FromUTF8String();
            return AsymmetricEncrypt(inputBuffer).ToBase64String();
        }
        #endregion
        #region Decrypt
        /// <summary>
        /// 使用RSA进行非对称解密
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="keyBlob">RSA私钥Blob字节数组</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] AsymmetricDecrypt(byte[] inputBuffer, byte[] keyBlob)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportCspBlob(keyBlob);
                if (inputBuffer.Length <= decryptCount)
                {
                    return RSA.Decrypt(inputBuffer, false);
                }
                else
                {
                    List<byte> list = new List<byte>();
                    while (inputBuffer.Any())
                    {
                        list.AddRange(RSA.Decrypt(inputBuffer.Take(decryptCount).ToArray(), false));
                        inputBuffer = inputBuffer.Skip(decryptCount).ToArray();
                    }
                    return list.ToArray();
                }
            }
        }

        /// <summary>
        /// 使用RSA进行非对称解密
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="keyBlobString">RSA私钥Blob字符串（Base64）</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] AsymmetricDecrypt(byte[] inputBuffer, string keyBlobString)
        {
            byte[] keyBlob = keyBlobString.FromBase64String();
            return AsymmetricDecrypt(inputBuffer, keyBlob);
        }

        /// <summary>
        /// 使用RSA进行非对称解密，使用默认私钥
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] AsymmetricDecrypt(byte[] inputBuffer)
        {
            if (inputBuffer.Length <= decryptCount)
            {
                return _RSACryptoServiceProvider.Decrypt(inputBuffer, false);
            }
            else
            {
                List<byte> list = new List<byte>();
                while (inputBuffer.Any())
                {
                    list.AddRange(_RSACryptoServiceProvider.Decrypt(inputBuffer.Take(decryptCount).ToArray(), false));
                    inputBuffer = inputBuffer.Skip(decryptCount).ToArray();
                }
                return list.ToArray();
            }
        }

        /// <summary>
        /// 使用RSA进行非对称解密
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <param name="keyBlob">RSA私钥Blob字节数组</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string AsymmetricDecrypt(string inString, byte[] keyBlob)
        {
            byte[] inputBuffer = inString.FromBase64String();
            return AsymmetricDecrypt(inputBuffer, keyBlob).ToUTF8String();
        }

        /// <summary>
        /// 使用RSA进行非对称解密
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <param name="keyBlobString">RSA私钥Blob字符串（Base64）</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string AsymmetricDecrypt(string inString, string keyBlobString)
        {
            byte[] keyBlob = keyBlobString.FromBase64String();
            return AsymmetricDecrypt(inString, keyBlob);
        }

        /// <summary>
        /// 使用RSA进行非对称解密，使用默认私钥
        /// </summary>
        /// <param name="inString">待解密的字符串（Base64）</param>
        /// <returns>解密后的字符串（UTF8）</returns>
        public static string AsymmetricDecrypt(string inString)
        {
            byte[] inputBuffer = inString.FromBase64String();
            return AsymmetricDecrypt(inputBuffer).ToUTF8String();
        }
        #endregion
        #endregion
        #region 哈希加密
        /// <summary>
        /// 使用SHA256获取哈希字符串
        /// </summary>
        /// <param name="inString">源字符串（UTF8）</param>
        /// <returns>哈希字符串</returns>
        public static string HashString(string inString)
        {
            byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
            return _SHA256.ComputeHash(inputBuffer).ToBase64String();
        }

        /// <summary>
        /// 使用SHA256进行哈希加密
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <param name="key">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string HashEncrypt(string inString, string key)
        {
            return HashString(string.Format("{0}${1}", inString, key));
        }

        /// <summary>
        /// 使用SHA256进行哈希加密，密钥为默认值
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string HashEncrypt(string inString)
        {
            return HashEncrypt(inString, defaultKey);
        }
        #endregion
    }
}
