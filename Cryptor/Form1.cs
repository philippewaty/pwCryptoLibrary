using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pwCryptoLibrary;

namespace Cryptor
{
    public partial class Form1 : Form
    {
        private string RSAPublicKey = "";
        private string RSAPrivateKey = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitRSAKey_Click(object sender, EventArgs e)
        {
            CryptoService.RSAGenerateKeys(2048, ref RSAPublicKey, ref RSAPrivateKey);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitAlgorithms();
        }

        private void InitAlgorithms()
        {
            cboAlgorithms.Items.Clear();
            cboAlgorithms.Items.Add("AES");
            cboAlgorithms.Items.Add("TripleDES");
            cboAlgorithms.Items.Add("RSA");
            cboAlgorithms.SelectedIndex = 0;
        }

        private void cboAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInitRSAKey.Enabled = cboAlgorithms.SelectedIndex == 2;
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            string encrypted;
            switch (cboAlgorithms.SelectedIndex)
            {
                case 0:
                    encrypted = CryptoService.Encrypt(CryptoService.CryptoServiceEnum.AES, txtPassphrase.Text, txtTextToEncrypt.Text);
                    break;
                case 1:
                    encrypted = CryptoService.Encrypt(CryptoService.CryptoServiceEnum.TripleDES, txtPassphrase.Text, txtTextToEncrypt.Text);
                    break;
                case 2:
                    if (string.IsNullOrEmpty(RSAPublicKey) || string.IsNullOrEmpty(RSAPrivateKey))
                    {
                        MessageBox.Show("RSA keys must be initialized", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    encrypted = CryptoService.Encrypt(CryptoService.CryptoServiceEnum.RSA, null, txtTextToEncrypt.Text, RSAPublicKey);
                    break;
                default:
                    encrypted = "";
                    break;
            }
            txtEncryptedText.Text = encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string decrypted;
            switch (cboAlgorithms.SelectedIndex)
            {
                case 0:
                    decrypted = CryptoService.Decrypt(CryptoService.CryptoServiceEnum.AES, txtPassphrase.Text, txtEncryptedText.Text);
                    break;
                case 1:
                    decrypted = CryptoService.Decrypt(CryptoService.CryptoServiceEnum.TripleDES, txtPassphrase.Text, txtEncryptedText.Text);
                    break;
                case 2:
                    if (string.IsNullOrEmpty(RSAPublicKey) || string.IsNullOrEmpty(RSAPrivateKey))
                    {
                        MessageBox.Show("RSA keys must be initialized", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    decrypted = CryptoService.Decrypt(CryptoService.CryptoServiceEnum.RSA, null, txtEncryptedText.Text, RSAPrivateKey);
                    break;
                default:
                    decrypted = "";
                    break;
            }
            txtDecryptedText.Text = decrypted;
        }
    }
}
