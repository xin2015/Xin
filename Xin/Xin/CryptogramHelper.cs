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
            _TripleDES = TripleDES.Create();
            _MD5 = MD5.Create();
            defaultKey = "Hume2016!@";
        }

        private static TripleDES _TripleDES;
        private static MD5 _MD5;
        private static string defaultKey;

        /// <summary>
        /// 使用TripleDES进行对称加密
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="tdesKey">TripleDES算法的密钥</param>
        /// <param name="tdesIV">TripleDES算法的初始化向量</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            return _TripleDES.CreateEncryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用TripleDES进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="key">TripleDES算法的密钥字符串</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer, string key)
        {
            byte[] tdesKey = _MD5.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] tdesIV = tdesKey.Take(8).ToArray();
            return Encrypt(inputBuffer, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用TripleDES进行对称加密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] Encrypt(byte[] inputBuffer)
        {
            return Encrypt(inputBuffer, defaultKey);
        }

        /// <summary>
        /// 使用TripleDES进行对称加密
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <param name="tdesKey">TripleDES算法的密钥</param>
        /// <param name="tdesIV">TripleDES算法的初始化向量</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
            byte[] outputBuffer = Encrypt(inputBuffer, tdesKey, tdesIV);
            return Convert.ToBase64String(outputBuffer);
        }

        /// <summary>
        /// 使用TripleDES进行对称加密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <param name="key">TripleDES算法的密钥字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string inString, string key)
        {
            byte[] tdesKey = _MD5.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] tdesIV = tdesKey.Take(8).ToArray();
            return Encrypt(inString, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用TripleDES进行对称加密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string inString)
        {
            return Encrypt(inString, defaultKey);
        }

        /// <summary>
        /// 使用Aes进行对称加密
        /// </summary>
        /// <param name="inputBuffer">待加密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>加密后的字节数组</returns>
        public static byte[] EncryptByAes(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] outputBuffer;
            using (Aes aes = Aes.Create())
            {
                outputBuffer = aes.CreateEncryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            }
            return outputBuffer;
        }

        /// <summary>
        /// 使用Aes进行对称加密
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptByAes(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
            byte[] outputBuffer = EncryptByAes(inputBuffer, tdesKey, tdesIV);
            return Convert.ToBase64String(outputBuffer);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="tdesKey">TripleDES算法的密钥</param>
        /// <param name="tdesIV">TripleDES算法的初始化向量</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            return _TripleDES.CreateDecryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="key">TripleDES算法的密钥字符串</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer, string key)
        {
            byte[] tdesKey = _MD5.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] tdesIV = tdesKey.Take(8).ToArray();
            return Decrypt(inputBuffer, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] Decrypt(byte[] inputBuffer)
        {
            return Decrypt(inputBuffer, defaultKey);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密
        /// </summary>
        /// <param name="inString">待解密的字符串</param>
        /// <param name="tdesKey">TripleDES算法的密钥</param>
        /// <param name="tdesIV">TripleDES算法的初始化向量</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = Convert.FromBase64String(inString);
            byte[] outputBuffer = Decrypt(inputBuffer, tdesKey, tdesIV);
            return Encoding.UTF8.GetString(outputBuffer);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密，密钥与初始化向量关联
        /// </summary>
        /// <param name="inString">待解密的字符串</param>
        /// <param name="key">TripleDES算法的密钥字符串</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string inString, string key)
        {
            byte[] tdesKey = _MD5.ComputeHash(Encoding.UTF8.GetBytes(key));
            byte[] tdesIV = tdesKey.Take(8).ToArray();
            return Decrypt(inString, tdesKey, tdesIV);
        }

        /// <summary>
        /// 使用TripleDES进行对称解密，密钥和初始化向量为默认值
        /// </summary>
        /// <param name="inString">待解密的字符串</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string inString)
        {
            return Decrypt(inString, defaultKey);
        }

        /// <summary>
        /// 使用Aes进行对称解密
        /// </summary>
        /// <param name="inputBuffer">待解密的字节数组</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] DecryptByAes(byte[] inputBuffer, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] outputBuffer;
            using (Aes aes = Aes.Create())
            {
                outputBuffer = aes.CreateDecryptor(tdesKey, tdesIV).TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            }
            return outputBuffer;
        }

        /// <summary>
        /// 使用Aes进行对称解密
        /// </summary>
        /// <param name="inString">待解密的字符串</param>
        /// <param name="tdesKey">Aes算法的密钥</param>
        /// <param name="tdesIV">Aes算法的初始化向量</param>
        /// <returns>解密后的字符串</returns>
        public static string DecryptByAes(string inString, byte[] tdesKey, byte[] tdesIV)
        {
            byte[] inputBuffer = Convert.FromBase64String(inString);
            byte[] outputBuffer = Decrypt(inputBuffer, tdesKey, tdesIV);
            return Encoding.UTF8.GetString(outputBuffer);
        }

        /// <summary>
        /// 使用MD5获取哈希字符串
        /// </summary>
        /// <param name="inString">源字符串</param>
        /// <returns>哈希字符串</returns>
        public static string HashString(string inString)
        {
            byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
            return Convert.ToBase64String(_MD5.ComputeHash(inputBuffer));
        }

        /// <summary>
        /// 使用SHA256获取哈希字符串
        /// </summary>
        /// <param name="inString">源字符串</param>
        /// <returns>哈希字符串</returns>
        public static string HashStringBySHA256(string inString)
        {
            byte[] outputBuffer;
            using (SHA256 _SHA256 = SHA256.Create())
            {
                byte[] inputBuffer = Encoding.UTF8.GetBytes(inString);
                outputBuffer = _SHA256.ComputeHash(inputBuffer);
            }
            return Convert.ToBase64String(outputBuffer);
        }

        /// <summary>
        /// 使用MD5进行哈希加密
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <param name="key">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string HashEncrypt(string inString, string key)
        {
            return HashString(string.Format("{0}${1}", inString, key));
        }

        /// <summary>
        /// 使用MD5进行哈希加密，密钥为默认值
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string HashEncrypt(string inString)
        {
            return HashEncrypt(inString, defaultKey);
        }

        /// <summary>
        /// 使用SHA256进行哈希加密
        /// </summary>
        /// <param name="inString">待加密的字符串</param>
        /// /// <param name="key">密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string HashEncryptBySHA256(string inString, string key)
        {
            return HashStringBySHA256(string.Format("{0}${1}", inString, key));
        }
    }
}
