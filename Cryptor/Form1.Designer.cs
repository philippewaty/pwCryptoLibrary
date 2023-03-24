
namespace Cryptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTextToEncrypt = new System.Windows.Forms.Label();
            this.txtTextToEncrypt = new System.Windows.Forms.TextBox();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.cboAlgorithms = new System.Windows.Forms.ComboBox();
            this.btnInitRSAKey = new System.Windows.Forms.Button();
            this.lblPassphrase = new System.Windows.Forms.Label();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "A library to encrypt/decrypt strings";
            // 
            // lblTextToEncrypt
            // 
            this.lblTextToEncrypt.AutoSize = true;
            this.lblTextToEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextToEncrypt.Location = new System.Drawing.Point(15, 65);
            this.lblTextToEncrypt.Name = "lblTextToEncrypt";
            this.lblTextToEncrypt.Size = new System.Drawing.Size(149, 24);
            this.lblTextToEncrypt.TabIndex = 1;
            this.lblTextToEncrypt.Text = "Text to encrypt";
            // 
            // txtTextToEncrypt
            // 
            this.txtTextToEncrypt.Location = new System.Drawing.Point(18, 92);
            this.txtTextToEncrypt.Multiline = true;
            this.txtTextToEncrypt.Name = "txtTextToEncrypt";
            this.txtTextToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToEncrypt.Size = new System.Drawing.Size(533, 54);
            this.txtTextToEncrypt.TabIndex = 2;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedText.Location = new System.Drawing.Point(15, 149);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(121, 24);
            this.lblEncryptedText.TabIndex = 3;
            this.lblEncryptedText.Text = "Crypted text";
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(18, 176);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncryptedText.Size = new System.Drawing.Size(533, 54);
            this.txtEncryptedText.TabIndex = 4;
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.AutoSize = true;
            this.lblDecryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptedText.Location = new System.Drawing.Point(15, 233);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(144, 24);
            this.lblDecryptedText.TabIndex = 5;
            this.lblDecryptedText.Text = "Decrypted text";
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(18, 260);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecryptedText.Size = new System.Drawing.Size(533, 54);
            this.txtDecryptedText.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassphrase);
            this.groupBox1.Controls.Add(this.lblPassphrase);
            this.groupBox1.Controls.Add(this.btnInitRSAKey);
            this.groupBox1.Controls.Add(this.cboAlgorithms);
            this.groupBox1.Controls.Add(this.lblAlgorithm);
            this.groupBox1.Location = new System.Drawing.Point(557, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypt algorithm";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.Location = new System.Drawing.Point(15, 61);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(59, 13);
            this.lblAlgorithm.TabIndex = 2;
            this.lblAlgorithm.Text = "Algorithm";
            // 
            // cboAlgorithms
            // 
            this.cboAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlgorithms.FormattingEnabled = true;
            this.cboAlgorithms.Location = new System.Drawing.Point(18, 86);
            this.cboAlgorithms.Name = "cboAlgorithms";
            this.cboAlgorithms.Size = new System.Drawing.Size(189, 21);
            this.cboAlgorithms.TabIndex = 3;
            this.cboAlgorithms.SelectedIndexChanged += new System.EventHandler(this.cboAlgorithms_SelectedIndexChanged);
            // 
            // btnInitRSAKey
            // 
            this.btnInitRSAKey.Enabled = false;
            this.btnInitRSAKey.Location = new System.Drawing.Point(18, 117);
            this.btnInitRSAKey.Name = "btnInitRSAKey";
            this.btnInitRSAKey.Size = new System.Drawing.Size(75, 23);
            this.btnInitRSAKey.TabIndex = 4;
            this.btnInitRSAKey.Text = "Init RSA key";
            this.btnInitRSAKey.UseVisualStyleBackColor = true;
            this.btnInitRSAKey.Click += new System.EventHandler(this.btnInitRSAKey_Click);
            // 
            // lblPassphrase
            // 
            this.lblPassphrase.AutoSize = true;
            this.lblPassphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassphrase.Location = new System.Drawing.Point(13, 16);
            this.lblPassphrase.Name = "lblPassphrase";
            this.lblPassphrase.Size = new System.Drawing.Size(72, 13);
            this.lblPassphrase.TabIndex = 0;
            this.lblPassphrase.Text = "Passphrase";
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(16, 32);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(189, 20);
            this.txtPassphrase.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Image = global::Cryptor.Properties.Resources.document_decrypt;
            this.btnDecrypt.Location = new System.Drawing.Point(88, 322);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(48, 48);
            this.btnDecrypt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnDecrypt, "Decrypt encrypted text");
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnCrypt
            // 
            this.btnCrypt.Image = global::Cryptor.Properties.Resources.document_encrypt;
            this.btnCrypt.Location = new System.Drawing.Point(19, 322);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(48, 48);
            this.btnCrypt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCrypt, "Crypt text");
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.txtEncryptedText);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.txtTextToEncrypt);
            this.Controls.Add(this.lblTextToEncrypt);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "pwCryptoLibrary Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTextToEncrypt;
        private System.Windows.Forms.TextBox txtTextToEncrypt;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInitRSAKey;
        private System.Windows.Forms.ComboBox cboAlgorithms;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.Label lblPassphrase;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

