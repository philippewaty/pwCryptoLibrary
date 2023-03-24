using System;
using System.Security.Cryptography;
using System.Text;

namespace pwCryptoLibrary
{
    internal class RSACryptoService : ICryptoLibrary
    {
        int keySize = 2048;


        public RSACryptoService(int keySize)
        {
            this.keySize = keySize;
        }

        public void GenerateKeys(int keySize, ref string publicKey, ref string privateKey)
        {
            if (keySize % 2 != 0 || keySize < 512)
                throw new System.Exception("Key should be multiple of two and greater than 512.");

            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(keySize);
            RSAParameters publicKeyParam = rsaCryptoServiceProvider.ExportParameters(false);
            RSAParameters privateKeyParam = rsaCryptoServiceProvider.ExportParameters(true);
            publicKey = rsaCryptoServiceProvider.ToXmlString(false);
            privateKey = rsaCryptoServiceProvider.ToXmlString(true);
        }

        public string Decrypt(string passphrase, string input, string RSAPrivateKey = "")
        {
            if (input == null || input.Length < 1)
            {
                throw new ArgumentNullException("RSA input text missing");
            }

            if (string.IsNullOrEmpty(RSAPrivateKey))
                throw new ArgumentException("RSAPrivateKey is needed");


            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                var cipherByteData = Convert.FromBase64String(input);

                rsa.FromXmlString(RSAPrivateKey);

                var encryptData = rsa.Decrypt(cipherByteData, false);
                return Encoding.UTF8.GetString(encryptData);
            }
        }

        public string Encrypt(string passphrase, string input, string RSAPublicKey = "")
        {
            if (input == null || input.Length < 1)
            {
                throw new ArgumentNullException("RSA input text missing");
            }

            if (string.IsNullOrEmpty(RSAPublicKey))
                throw new ArgumentException("RSAPublicKey is needed");

            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.FromXmlString(RSAPublicKey);

                var byteData = Encoding.UTF8.GetBytes(input);
                var encryptData = rsa.Encrypt(byteData, false);
                return Convert.ToBase64String(encryptData);
            }
        }

        public string Encrypt(string passphrase, string input)
        {
            throw new NotImplementedException();
        }

        public string Decrypt(string passphrase, string input)
        {
            throw new NotImplementedException();
        }
    }
}
