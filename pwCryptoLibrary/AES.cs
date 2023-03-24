using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace pwCryptoLibrary
{
    internal class AES : ICryptoLibrary
    {
        private Aes InitAes()
        {
            Aes aes = Aes.Create();

            aes.KeySize = aes.LegalKeySizes
                .Max(n => n.MaxSize);

            return aes;
        }
        public string Decrypt(string passphrase, string input)
        {
            var key = CreateMd5Hash(passphrase);
            var fullCipher = Convert.FromBase64String(input);
            var iv = new byte[16];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, fullCipher.Length - iv.Length);

            string result;

            using (Aes aes = InitAes())
            {
                using (var decryptor = aes.CreateDecryptor(key, iv))
                {
                    using (var memoryStream = new MemoryStream(cipher))
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (var streamReader = new StreamReader(cryptoStream))
                            {
                                result = streamReader.ReadToEnd();
                            }
                        }
                    }
                }

                return result;
            }
        }

        public string Encrypt(string passphrase, string input)
        {
            var key = CreateMd5Hash(passphrase);

            using (var aes = InitAes())
            {
                aes.KeySize = aes.LegalKeySizes
                        .Max(n => n.MaxSize);

                using (var encryptor = aes.CreateEncryptor(key, aes.IV))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {

                            using (var streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(input);
                            }

                            var iv = aes.IV;
                            var bytes = memoryStream.ToArray();
                            var result = new byte[iv.Length + bytes.Length];

                            Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                            Buffer.BlockCopy(bytes, 0, result, iv.Length, bytes.Length);
                            return Convert.ToBase64String(result);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Create a MD5 hash of the input string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Created MD5 hash.</returns>
        private static byte[] CreateMd5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return Encoding.UTF8.GetBytes(sb.ToString());
            }
        }

    }
}
