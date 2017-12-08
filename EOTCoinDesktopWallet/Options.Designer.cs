namespace EOTCoinDesktopWallet
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.GenerateWalletButton = new System.Windows.Forms.Button();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectedPictureBox = new System.Windows.Forms.PictureBox();
            this.ConnectedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(81, 34);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(271, 46);
            this.ExportButton.TabIndex = 11;
            this.ExportButton.Text = "Export Wallet Seed";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(81, 113);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(271, 46);
            this.ImportButton.TabIndex = 12;
            this.ImportButton.Text = "Import Wallet Seed";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(81, 261);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(271, 46);
            this.DashboardButton.TabIndex = 13;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // GenerateWalletButton
            // 
            this.GenerateWalletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateWalletButton.Location = new System.Drawing.Point(81, 188);
            this.GenerateWalletButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateWalletButton.Name = "GenerateWalletButton";
            this.GenerateWalletButton.Size = new System.Drawing.Size(271, 46);
            this.GenerateWalletButton.TabIndex = 14;
            this.GenerateWalletButton.Text = "Generate new wallet";
            this.GenerateWalletButton.UseVisualStyleBackColor = true;
            this.GenerateWalletButton.Click += new System.EventHandler(this.GenerateWalletButton_Click);
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Location = new System.Drawing.Point(341, 313);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(0, 17);
            this.ConnectedLabel.TabIndex = 15;
            // 
            // ConnectedPictureBox
            // 
            this.ConnectedPictureBox.Location = new System.Drawing.Point(393, 313);
            this.ConnectedPictureBox.Name = "ConnectedPictureBox";
            this.ConnectedPictureBox.Size = new System.Drawing.Size(30, 17);
            this.ConnectedPictureBox.TabIndex = 16;
            this.ConnectedPictureBox.TabStop = false;
            // 
            // ConnectedTimer
            // 
            this.ConnectedTimer.Enabled = true;
            this.ConnectedTimer.Interval = 1500;
            this.ConnectedTimer.Tick += new System.EventHandler(this.ConnectedTimer_Tick);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 337);
            this.Controls.Add(this.ConnectedPictureBox);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.GenerateWalletButton);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOT Coin Wallet";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button GenerateWalletButton;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.PictureBox ConnectedPictureBox;
        private System.Windows.Forms.Timer ConnectedTimer;
    }
}