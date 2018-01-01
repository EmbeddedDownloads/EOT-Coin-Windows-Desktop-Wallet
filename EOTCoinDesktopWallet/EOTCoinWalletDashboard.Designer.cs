namespace EOTCoinDesktopWallet
{
    partial class EOTCoinWalletDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EOTCoinWalletDashboard));
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.ReceieveButton = new System.Windows.Forms.Button();
            this.publicLabel = new System.Windows.Forms.Label();
            this.BalanceLabel1 = new System.Windows.Forms.Label();
            this.BalanceLabel2 = new System.Windows.Forms.Label();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnectedPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordVault = new System.Windows.Forms.Button();
            this.CryptoDocButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(37, 430);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(175, 29);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address Label";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(351, 71);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(115, 39);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(351, 14);
            this.TransactionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(251, 46);
            this.TransactionsButton.TabIndex = 4;
            this.TransactionsButton.Text = "View Transactions";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // ReceieveButton
            // 
            this.ReceieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceieveButton.Location = new System.Drawing.Point(481, 71);
            this.ReceieveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReceieveButton.Name = "ReceieveButton";
            this.ReceieveButton.Size = new System.Drawing.Size(120, 39);
            this.ReceieveButton.TabIndex = 5;
            this.ReceieveButton.Text = "Receive";
            this.ReceieveButton.UseVisualStyleBackColor = true;
            this.ReceieveButton.Click += new System.EventHandler(this.ReceieveButton_Click);
            // 
            // publicLabel
            // 
            this.publicLabel.AutoSize = true;
            this.publicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicLabel.Location = new System.Drawing.Point(37, 394);
            this.publicLabel.Name = "publicLabel";
            this.publicLabel.Size = new System.Drawing.Size(245, 29);
            this.publicLabel.TabIndex = 6;
            this.publicLabel.Text = "Public EOT address:";
            this.publicLabel.Click += new System.EventHandler(this.publicLabel_Click);
            // 
            // BalanceLabel1
            // 
            this.BalanceLabel1.AutoSize = true;
            this.BalanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel1.Location = new System.Drawing.Point(347, 316);
            this.BalanceLabel1.Name = "BalanceLabel1";
            this.BalanceLabel1.Size = new System.Drawing.Size(119, 29);
            this.BalanceLabel1.TabIndex = 7;
            this.BalanceLabel1.Text = "Balance: ";
            // 
            // BalanceLabel2
            // 
            this.BalanceLabel2.AutoSize = true;
            this.BalanceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel2.Location = new System.Drawing.Point(453, 346);
            this.BalanceLabel2.Name = "BalanceLabel2";
            this.BalanceLabel2.Size = new System.Drawing.Size(48, 29);
            this.BalanceLabel2.TabIndex = 8;
            this.BalanceLabel2.Text = "0.0";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(351, 123);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(251, 46);
            this.OptionsButton.TabIndex = 11;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(516, 484);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(92, 17);
            this.VersionLabel.TabIndex = 12;
            this.VersionLabel.Text = "Version 3.0.0";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(43, 475);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(123, 26);
            this.CopyButton.TabIndex = 13;
            this.CopyButton.Text = "Copy Address";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(481, 378);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh balance";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Location = new System.Drawing.Point(385, 482);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(12, 17);
            this.ConnectedLabel.TabIndex = 15;
            this.ConnectedLabel.Text = " ";
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Enabled = true;
            this.ConnectionTimer.Interval = 1500;
            this.ConnectionTimer.Tick += new System.EventHandler(this.ConnectionTimer_Tick);
            // 
            // ConnectedPictureBox
            // 
            this.ConnectedPictureBox.InitialImage = null;
            this.ConnectedPictureBox.Location = new System.Drawing.Point(435, 484);
            this.ConnectedPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectedPictureBox.Name = "ConnectedPictureBox";
            this.ConnectedPictureBox.Size = new System.Drawing.Size(29, 17);
            this.ConnectedPictureBox.TabIndex = 16;
            this.ConnectedPictureBox.TabStop = false;
            this.ConnectedPictureBox.Click += new System.EventHandler(this.ConnectedPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordVault
            // 
            this.PasswordVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordVault.Location = new System.Drawing.Point(351, 179);
            this.PasswordVault.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordVault.Name = "PasswordVault";
            this.PasswordVault.Size = new System.Drawing.Size(248, 48);
            this.PasswordVault.TabIndex = 17;
            this.PasswordVault.Text = "Password Vault";
            this.PasswordVault.UseVisualStyleBackColor = true;
            this.PasswordVault.Click += new System.EventHandler(this.PasswordVault_Click);
            // 
            // CryptoDocButton
            // 
            this.CryptoDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptoDocButton.Location = new System.Drawing.Point(351, 240);
            this.CryptoDocButton.Name = "CryptoDocButton";
            this.CryptoDocButton.Size = new System.Drawing.Size(248, 45);
            this.CryptoDocButton.TabIndex = 18;
            this.CryptoDocButton.Text = "Crypto Doc";
            this.CryptoDocButton.UseVisualStyleBackColor = true;
            this.CryptoDocButton.Click += new System.EventHandler(this.CryptoDocButton_Click);
            // 
            // EOTCoinWalletDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 510);
            this.Controls.Add(this.CryptoDocButton);
            this.Controls.Add(this.PasswordVault);
            this.Controls.Add(this.ConnectedPictureBox);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BalanceLabel2);
            this.Controls.Add(this.BalanceLabel1);
            this.Controls.Add(this.publicLabel);
            this.Controls.Add(this.ReceieveButton);
            this.Controls.Add(this.TransactionsButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AddressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EOTCoinWalletDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOT Coin Wallet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button ReceieveButton;
        private System.Windows.Forms.Label publicLabel;
        private System.Windows.Forms.Label BalanceLabel1;
        private System.Windows.Forms.Label BalanceLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.Timer ConnectionTimer;
        private System.Windows.Forms.PictureBox ConnectedPictureBox;
        private System.Windows.Forms.Button PasswordVault;
        private System.Windows.Forms.Button CryptoDocButton;
    }
}

