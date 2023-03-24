namespace pwCryptoLibrary
{
    interface ICryptoLibrary
    {
        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="passphrase">Passphrase</param>
        /// <param name="input">Decrypted message</param>
        /// <returns></returns>
        string Encrypt(string passphrase, string input);

        /// <summary>
        /// Decrypt a string
        /// </summary>
        /// <param name="passphrase">Passphrase</param>
        /// <param name="input">Encrypted message</param>
        /// <returns></returns>
        string Decrypt(string passphrase, string input);

    }
}
