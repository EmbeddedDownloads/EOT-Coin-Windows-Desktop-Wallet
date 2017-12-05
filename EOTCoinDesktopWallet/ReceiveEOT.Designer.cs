namespace EOTCoinDesktopWallet
{
    partial class ReceiveEOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveEOT));
            this.DashboardButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.CopyClipboardButton = new System.Windows.Forms.Button();
            this.QRCodePictureBox = new System.Windows.Forms.PictureBox();
            this.ScanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DashboardButton.Location = new System.Drawing.Point(17, 382);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(162, 40);
            this.DashboardButton.TabIndex = 0;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendButton.Location = new System.Drawing.Point(17, 334);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(162, 40);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "The following EOT address can be used for receceiving EOT coins:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addressLabel.Location = new System.Drawing.Point(13, 69);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(106, 29);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            this.addressLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CopyClipboardButton
            // 
            this.CopyClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CopyClipboardButton.Location = new System.Drawing.Point(642, 63);
            this.CopyClipboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyClipboardButton.Name = "CopyClipboardButton";
            this.CopyClipboardButton.Size = new System.Drawing.Size(135, 40);
            this.CopyClipboardButton.TabIndex = 4;
            this.CopyClipboardButton.Text = "Copy address";
            this.CopyClipboardButton.UseVisualStyleBackColor = true;
            this.CopyClipboardButton.Click += new System.EventHandler(this.CopyClipboardButton_Click);
            // 
            // QRCodePictureBox
            // 
            this.QRCodePictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QRCodePictureBox.Location = new System.Drawing.Point(294, 219);
            this.QRCodePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.QRCodePictureBox.Name = "QRCodePictureBox";
            this.QRCodePictureBox.Size = new System.Drawing.Size(248, 226);
            this.QRCodePictureBox.TabIndex = 5;
            this.QRCodePictureBox.TabStop = false;
            // 
            // ScanLabel
            // 
            this.ScanLabel.AutoSize = true;
            this.ScanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ScanLabel.Location = new System.Drawing.Point(289, 169);
            this.ScanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScanLabel.Name = "ScanLabel";
            this.ScanLabel.Size = new System.Drawing.Size(228, 25);
            this.ScanLabel.TabIndex = 6;
            this.ScanLabel.Text = "Scan the QR code below";
            this.ScanLabel.Click += new System.EventHandler(this.ScanLabel_Click);
            // 
            // ReceiveEOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 521);
            this.Controls.Add(this.ScanLabel);
            this.Controls.Add(this.QRCodePictureBox);
            this.Controls.Add(this.CopyClipboardButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.DashboardButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiveEOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive EOT Coins";
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button CopyClipboardButton;
        private System.Windows.Forms.PictureBox QRCodePictureBox;
        private System.Windows.Forms.Label ScanLabel;
    }
}