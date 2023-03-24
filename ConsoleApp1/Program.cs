using pwCryptoLibrary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToEncrypt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus.";
            string passPhrase = "your passphrase";
            string cryptedText;
            string decryptedText;
            string RSAPublicKey = "";
            string RSAPrivateKey = "";

            Console.WriteLine("Text to crypt");
            Console.WriteLine(textToEncrypt);
            Console.WriteLine("");

            Console.WriteLine("AES");
            Console.WriteLine("---");
            cryptedText = CryptoService.Encrypt(CryptoService.CryptoServiceEnum.AES, passPhrase, textToEncrypt);
            Console.WriteLine("cryptedText");
            Console.WriteLine(cryptedText);
            Console.WriteLine();
            decryptedText = CryptoService.Decrypt(CryptoService.CryptoServiceEnum.AES, passPhrase, cryptedText);
            Console.WriteLine("decryptedText");
            Console.WriteLine(decryptedText);

            Console.WriteLine();

            Console.WriteLine("RSA");
            Console.WriteLine("---");
            CryptoService.RSAGenerateKeys(2048, ref RSAPublicKey, ref RSAPrivateKey);
            cryptedText = CryptoService.Encrypt(CryptoService.CryptoServiceEnum.RSA, "", textToEncrypt, RSAPublicKey);
            Console.WriteLine("cryptedText");
            Console.WriteLine(cryptedText);
            Console.WriteLine();
            decryptedText = CryptoService.Decrypt(CryptoService.CryptoServiceEnum.RSA, "", cryptedText, RSAPrivateKey);
            Console.WriteLine("decryptedText");
            Console.WriteLine(decryptedText);

            Console.ReadKey();
        }
    }
}
