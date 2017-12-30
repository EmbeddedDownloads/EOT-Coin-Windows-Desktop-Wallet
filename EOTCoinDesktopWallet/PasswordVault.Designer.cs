namespace EOTCoinDesktopWallet
{
    partial class PasswordVault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordVault));
            this.TextToEncryptBox = new System.Windows.Forms.RichTextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.PasswordPasswordVault = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextToEncryptBox
            // 
            this.TextToEncryptBox.Location = new System.Drawing.Point(12, 12);
            this.TextToEncryptBox.Name = "TextToEncryptBox";
            this.TextToEncryptBox.Size = new System.Drawing.Size(745, 307);
            this.TextToEncryptBox.TabIndex = 0;
            this.TextToEncryptBox.Text = "";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Location = new System.Drawing.Point(144, 371);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(133, 35);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptButton.Location = new System.Drawing.Point(306, 371);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(138, 35);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(467, 370);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(154, 34);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // PasswordPasswordVault
            // 
            this.PasswordPasswordVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordPasswordVault.Location = new System.Drawing.Point(144, 335);
            this.PasswordPasswordVault.Name = "PasswordPasswordVault";
            this.PasswordPasswordVault.Size = new System.Drawing.Size(299, 30);
            this.PasswordPasswordVault.TabIndex = 4;
            this.PasswordPasswordVault.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(34, 335);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 25);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // PasswordVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordPasswordVault);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.TextToEncryptBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordVault";
            this.Text = "Password Vault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextToEncryptBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.TextBox PasswordPasswordVault;
        private System.Windows.Forms.Label PasswordLabel;
    }
}