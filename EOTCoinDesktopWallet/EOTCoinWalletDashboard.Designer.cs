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
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(28, 289);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(138, 25);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address Label";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(263, 62);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(86, 32);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(263, 11);
            this.TransactionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(188, 37);
            this.TransactionsButton.TabIndex = 4;
            this.TransactionsButton.Text = "View Transactions";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // ReceieveButton
            // 
            this.ReceieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceieveButton.Location = new System.Drawing.Point(361, 62);
            this.ReceieveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceieveButton.Name = "ReceieveButton";
            this.ReceieveButton.Size = new System.Drawing.Size(90, 32);
            this.ReceieveButton.TabIndex = 5;
            this.ReceieveButton.Text = "Receive";
            this.ReceieveButton.UseVisualStyleBackColor = true;
            this.ReceieveButton.Click += new System.EventHandler(this.ReceieveButton_Click);
            // 
            // publicLabel
            // 
            this.publicLabel.AutoSize = true;
            this.publicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicLabel.Location = new System.Drawing.Point(28, 260);
            this.publicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publicLabel.Name = "publicLabel";
            this.publicLabel.Size = new System.Drawing.Size(193, 25);
            this.publicLabel.TabIndex = 6;
            this.publicLabel.Text = "Public EOT address:";
            // 
            // BalanceLabel1
            // 
            this.BalanceLabel1.AutoSize = true;
            this.BalanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel1.Location = new System.Drawing.Point(260, 209);
            this.BalanceLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceLabel1.Name = "BalanceLabel1";
            this.BalanceLabel1.Size = new System.Drawing.Size(94, 25);
            this.BalanceLabel1.TabIndex = 7;
            this.BalanceLabel1.Text = "Balance: ";
            // 
            // BalanceLabel2
            // 
            this.BalanceLabel2.AutoSize = true;
            this.BalanceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel2.Location = new System.Drawing.Point(340, 233);
            this.BalanceLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceLabel2.Name = "BalanceLabel2";
            this.BalanceLabel2.Size = new System.Drawing.Size(39, 25);
            this.BalanceLabel2.TabIndex = 8;
            this.BalanceLabel2.Text = "0.0";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(263, 104);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(188, 37);
            this.OptionsButton.TabIndex = 11;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(387, 333);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(66, 13);
            this.VersionLabel.TabIndex = 12;
            this.VersionLabel.Text = "Version 2.00";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(32, 326);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(92, 21);
            this.CopyButton.TabIndex = 13;
            this.CopyButton.Text = "Copy Address";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(361, 259);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(90, 19);
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
            this.ConnectedLabel.Location = new System.Drawing.Point(292, 333);
            this.ConnectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(10, 13);
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
            this.ConnectedPictureBox.Location = new System.Drawing.Point(326, 333);
            this.ConnectedPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectedPictureBox.Name = "ConnectedPictureBox";
            this.ConnectedPictureBox.Size = new System.Drawing.Size(22, 14);
            this.ConnectedPictureBox.TabIndex = 16;
            this.ConnectedPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordVault
            // 
            this.PasswordVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordVault.Location = new System.Drawing.Point(263, 157);
            this.PasswordVault.Name = "PasswordVault";
            this.PasswordVault.Size = new System.Drawing.Size(186, 37);
            this.PasswordVault.TabIndex = 17;
            this.PasswordVault.Text = "Password Vault";
            this.PasswordVault.UseVisualStyleBackColor = true;
            this.PasswordVault.Click += new System.EventHandler(this.PasswordVault_Click);
            // 
            // EOTCoinWalletDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 354);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

