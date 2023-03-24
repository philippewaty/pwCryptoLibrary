using System;
using System.Security.Cryptography;

namespace pwCryptoLibrary
{
    internal class TripleDES : ICryptoLibrary
    {
        private System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

        /// <summary>
        /// Init TripleDES service provider
        /// </summary>
        /// <param name="passphrase"></param>
        /// <returns></returns>
        private TripleDESCryptoServiceProvider InitDES(string passphrase)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();

            // Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(encoding.GetBytes(passphrase));
            hashMD5.Clear();
            // Set the cipher mode.
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.PKCS7;

            return DES;
        }
        public string Decrypt(string passphrase, string input)
        {
            TripleDESCryptoServiceProvider DES = InitDES(passphrase);

            if (string.IsNullOrEmpty(input)) return "";
            // Create the decryptor.
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();
            byte[] Buffer = Convert.FromBase64String(input);
            // Transform and return the string.
            return encoding.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public string Encrypt(string passphrase, string input)
        {
            TripleDESCryptoServiceProvider DES = InitDES(passphrase);

            // Create the encryptor.
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            // Get a byte array of the string.
            byte[] Buffer = encoding.GetBytes(input);
            // Transform and return the string.
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }
    }
}
