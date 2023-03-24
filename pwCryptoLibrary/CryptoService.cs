namespace pwCryptoLibrary
{
    public class CryptoService
    {
        int RSAKeySize;

        public CryptoService(int RSAKeySize)
        {
            this.RSAKeySize = RSAKeySize;
        }

        public enum CryptoServiceEnum
        {
            TripleDES,
            AES,
            RSA
        }



        /// <summary>
        /// Encrypt a message
        /// </summary>
        /// <param name="crypto">Encryption type</param>
        /// <param name="key">Security key. Can be empty for RSA</param>
        /// <param name="input">Message to encrypt</param>
        /// <param name="RSAPublicKey">Public key for RSA</param>
        /// <returns>The encrypted message</returns>
        public static string Encrypt(CryptoServiceEnum crypto, string key, string input, string RSAPublicKey = "")
        {
            string encrypted = "";
            switch (crypto)
            {
                case CryptoServiceEnum.TripleDES:
                    TripleDES tripleDES = new TripleDES();
                    encrypted = tripleDES.Encrypt(key, input);
                    break;
                case CryptoServiceEnum.AES:
                    AES aes = new AES();
                    encrypted = aes.Encrypt(key, input);
                    break;
                case CryptoServiceEnum.RSA:
                    RSACryptoService rsa = new RSACryptoService(2048);
                    encrypted = rsa.Encrypt(key, input, RSAPublicKey);
                    break;
            }
            return encrypted;
        }

        /// <summary>
        /// Decrypt a crypted message
        /// </summary>
        /// <param name="crypto">Encryption type</param>
        /// <param name="passphrase">Security key. Can be empty for RSA</param>
        /// <param name="input">Message to decrypt</param>
        /// <param name="RSAPrivateKey">Private key for RSA</param>
        /// <returns>The decrypted message</returns>
        public static string Decrypt(CryptoServiceEnum crypto, string passphrase, string input, string RSAPrivateKey = "")
        {
            string decrypted = "";
            switch (crypto)
            {
                case CryptoServiceEnum.TripleDES:
                    TripleDES tripleDES = new TripleDES();
                    decrypted = tripleDES.Decrypt(passphrase, input);
                    break;
                case CryptoServiceEnum.AES:
                    AES aes = new AES();
                    decrypted = aes.Decrypt(passphrase, input);
                    break;
                case CryptoServiceEnum.RSA:
                    RSACryptoService rsa = new RSACryptoService(2048);
                    decrypted = rsa.Decrypt(passphrase, input, RSAPrivateKey);
                    break;
            }
            return decrypted;
        }


        /// <summary>
        /// Generate public and private keys for RSA algorithm
        /// </summary>
        /// <param name="keySize">key size</param>
        /// <param name="publicKey">generated public key</param>
        /// <param name="privateKey">generated private key</param>
        public static void RSAGenerateKeys(int keySize, ref string publicKey, ref string privateKey)
        {
            RSACryptoService rsa = new RSACryptoService(2048);
            rsa.GenerateKeys(keySize, ref publicKey, ref privateKey);
        }
    }
}
