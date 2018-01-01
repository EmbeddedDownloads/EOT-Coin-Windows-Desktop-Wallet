namespace EOTCoinDesktopWallet
{
    partial class CryptoDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoDoc));
            this.CryptoDocOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EncryptFileButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.CryptoDocPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteOriginal = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteEncrypted = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CryptoDocOpenFileDialog
            // 
            this.CryptoDocOpenFileDialog.FileName = "CryptoDocOpenFileDialog";
            // 
            // EncryptFileButton
            // 
            this.EncryptFileButton.Image = ((System.Drawing.Image)(resources.GetObject("EncryptFileButton.Image")));
            this.EncryptFileButton.Location = new System.Drawing.Point(401, 75);
            this.EncryptFileButton.Name = "EncryptFileButton";
            this.EncryptFileButton.Size = new System.Drawing.Size(168, 187);
            this.EncryptFileButton.TabIndex = 0;
            this.EncryptFileButton.UseVisualStyleBackColor = true;
            this.EncryptFileButton.Click += new System.EventHandler(this.EncryptFileButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(706, 405);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(170, 46);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // CryptoDocPassword
            // 
            this.CryptoDocPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptoDocPassword.Location = new System.Drawing.Point(366, 411);
            this.CryptoDocPassword.Name = "CryptoDocPassword";
            this.CryptoDocPassword.Size = new System.Drawing.Size(230, 36);
            this.CryptoDocPassword.TabIndex = 2;
            this.CryptoDocPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password: ";
            // 
            // DeleteOriginal
            // 
            this.DeleteOriginal.AutoSize = true;
            this.DeleteOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOriginal.Location = new System.Drawing.Point(96, 315);
            this.DeleteOriginal.Name = "DeleteOriginal";
            this.DeleteOriginal.Size = new System.Drawing.Size(437, 33);
            this.DeleteOriginal.TabIndex = 4;
            this.DeleteOriginal.Text = "Delete Original File After Encryption";
            this.DeleteOriginal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1005, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 187);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CyptoDocDecryptButton_Click);
            // 
            // DeleteEncrypted
            // 
            this.DeleteEncrypted.AutoSize = true;
            this.DeleteEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEncrypted.Location = new System.Drawing.Point(751, 315);
            this.DeleteEncrypted.Name = "DeleteEncrypted";
            this.DeleteEncrypted.Size = new System.Drawing.Size(470, 33);
            this.DeleteEncrypted.TabIndex = 6;
            this.DeleteEncrypted.Text = "Delete Encrypted files After Decryption";
            this.DeleteEncrypted.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 236);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 236);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1209, 64);
            this.label4.TabIndex = 9;
            this.label4.Text = "When Experimenting with this software for the first time, please ensure you keep " +
    "backup copies of your files!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CryptoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteEncrypted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CryptoDocPassword);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.EncryptFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CryptoDoc";
            this.Text = "CryptoDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog CryptoDocOpenFileDialog;
        private System.Windows.Forms.Button EncryptFileButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.TextBox CryptoDocPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DeleteOriginal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox DeleteEncrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}