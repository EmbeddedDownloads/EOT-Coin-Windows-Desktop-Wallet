namespace EOTCoinDesktopWallet
{
    partial class SendEOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEOT));
            this.SendFromLabel = new System.Windows.Forms.Label();
            this.SendToLabel = new System.Windows.Forms.Label();
            this.AmountEOTLabel = new System.Windows.Forms.Label();
            this.AmountMinerFeesLabel = new System.Windows.Forms.Label();
            this.SendingAddressTextBox = new System.Windows.Forms.TextBox();
            this.ReceivingAddressTextBox = new System.Windows.Forms.TextBox();
            this.AmountEOTtextbox = new System.Windows.Forms.TextBox();
            this.EstimateAmountDollarTextBox = new System.Windows.Forms.TextBox();
            this.EstimateEOTDollarValue = new System.Windows.Forms.Label();
            this.MinerFeesTextBox = new System.Windows.Forms.TextBox();
            this.EstimateMinerFeeDollarTextBox = new System.Windows.Forms.TextBox();
            this.EstimateMinerFeeDollars = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendFromLabel
            // 
            this.SendFromLabel.AutoSize = true;
            this.SendFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendFromLabel.Location = new System.Drawing.Point(43, 34);
            this.SendFromLabel.Name = "SendFromLabel";
            this.SendFromLabel.Size = new System.Drawing.Size(144, 29);
            this.SendFromLabel.TabIndex = 0;
            this.SendFromLabel.Text = "Send from: ";
            // 
            // SendToLabel
            // 
            this.SendToLabel.AutoSize = true;
            this.SendToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendToLabel.Location = new System.Drawing.Point(43, 82);
            this.SendToLabel.Name = "SendToLabel";
            this.SendToLabel.Size = new System.Drawing.Size(114, 29);
            this.SendToLabel.TabIndex = 1;
            this.SendToLabel.Text = "Send to: ";
            // 
            // AmountEOTLabel
            // 
            this.AmountEOTLabel.AutoSize = true;
            this.AmountEOTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AmountEOTLabel.Location = new System.Drawing.Point(43, 129);
            this.AmountEOTLabel.Name = "AmountEOTLabel";
            this.AmountEOTLabel.Size = new System.Drawing.Size(182, 29);
            this.AmountEOTLabel.TabIndex = 2;
            this.AmountEOTLabel.Text = "Amount (EOT):";
            // 
            // AmountMinerFeesLabel
            // 
            this.AmountMinerFeesLabel.AutoSize = true;
            this.AmountMinerFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AmountMinerFeesLabel.Location = new System.Drawing.Point(43, 183);
            this.AmountMinerFeesLabel.Name = "AmountMinerFeesLabel";
            this.AmountMinerFeesLabel.Size = new System.Drawing.Size(212, 29);
            this.AmountMinerFeesLabel.TabIndex = 3;
            this.AmountMinerFeesLabel.Text = "Miner fees (EOT):";
            // 
            // SendingAddressTextBox
            // 
            this.SendingAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendingAddressTextBox.Location = new System.Drawing.Point(261, 31);
            this.SendingAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendingAddressTextBox.Name = "SendingAddressTextBox";
            this.SendingAddressTextBox.Size = new System.Drawing.Size(577, 36);
            this.SendingAddressTextBox.TabIndex = 4;
            // 
            // ReceivingAddressTextBox
            // 
            this.ReceivingAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReceivingAddressTextBox.Location = new System.Drawing.Point(261, 79);
            this.ReceivingAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReceivingAddressTextBox.Name = "ReceivingAddressTextBox";
            this.ReceivingAddressTextBox.Size = new System.Drawing.Size(577, 36);
            this.ReceivingAddressTextBox.TabIndex = 5;
            this.ReceivingAddressTextBox.TextChanged += new System.EventHandler(this.ReceivingAddressTextBox_TextChanged);
            // 
            // AmountEOTtextbox
            // 
            this.AmountEOTtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AmountEOTtextbox.Location = new System.Drawing.Point(261, 126);
            this.AmountEOTtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountEOTtextbox.Name = "AmountEOTtextbox";
            this.AmountEOTtextbox.Size = new System.Drawing.Size(253, 36);
            this.AmountEOTtextbox.TabIndex = 6;
            this.AmountEOTtextbox.TextChanged += new System.EventHandler(this.AmountEOTtextbox_TextChanged);
            // 
            // EstimateAmountDollarTextBox
            // 
            this.EstimateAmountDollarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EstimateAmountDollarTextBox.Location = new System.Drawing.Point(588, 126);
            this.EstimateAmountDollarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstimateAmountDollarTextBox.Name = "EstimateAmountDollarTextBox";
            this.EstimateAmountDollarTextBox.Size = new System.Drawing.Size(250, 36);
            this.EstimateAmountDollarTextBox.TabIndex = 7;
            // 
            // EstimateEOTDollarValue
            // 
            this.EstimateEOTDollarValue.AutoSize = true;
            this.EstimateEOTDollarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EstimateEOTDollarValue.Location = new System.Drawing.Point(531, 129);
            this.EstimateEOTDollarValue.Name = "EstimateEOTDollarValue";
            this.EstimateEOTDollarValue.Size = new System.Drawing.Size(42, 29);
            this.EstimateEOTDollarValue.TabIndex = 8;
            this.EstimateEOTDollarValue.Text = "~$";
            // 
            // MinerFeesTextBox
            // 
            this.MinerFeesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MinerFeesTextBox.Location = new System.Drawing.Point(261, 180);
            this.MinerFeesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinerFeesTextBox.Name = "MinerFeesTextBox";
            this.MinerFeesTextBox.Size = new System.Drawing.Size(253, 36);
            this.MinerFeesTextBox.TabIndex = 9;
            this.MinerFeesTextBox.TextChanged += new System.EventHandler(this.MinerFeesTextBox_TextChanged);
            // 
            // EstimateMinerFeeDollarTextBox
            // 
            this.EstimateMinerFeeDollarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EstimateMinerFeeDollarTextBox.Location = new System.Drawing.Point(588, 180);
            this.EstimateMinerFeeDollarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EstimateMinerFeeDollarTextBox.Name = "EstimateMinerFeeDollarTextBox";
            this.EstimateMinerFeeDollarTextBox.Size = new System.Drawing.Size(250, 36);
            this.EstimateMinerFeeDollarTextBox.TabIndex = 10;
            // 
            // EstimateMinerFeeDollars
            // 
            this.EstimateMinerFeeDollars.AutoSize = true;
            this.EstimateMinerFeeDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EstimateMinerFeeDollars.Location = new System.Drawing.Point(531, 183);
            this.EstimateMinerFeeDollars.Name = "EstimateMinerFeeDollars";
            this.EstimateMinerFeeDollars.Size = new System.Drawing.Size(42, 29);
            this.EstimateMinerFeeDollars.TabIndex = 11;
            this.EstimateMinerFeeDollars.Text = "~$";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendButton.Location = new System.Drawing.Point(261, 266);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 40);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DashboardButton.Location = new System.Drawing.Point(659, 268);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(179, 40);
            this.DashboardButton.TabIndex = 13;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordLabel.Location = new System.Drawing.Point(43, 228);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(131, 29);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordTextBox.Location = new System.Drawing.Point(261, 225);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(577, 36);
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // SendEOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 328);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EstimateMinerFeeDollars);
            this.Controls.Add(this.EstimateMinerFeeDollarTextBox);
            this.Controls.Add(this.MinerFeesTextBox);
            this.Controls.Add(this.EstimateEOTDollarValue);
            this.Controls.Add(this.EstimateAmountDollarTextBox);
            this.Controls.Add(this.AmountEOTtextbox);
            this.Controls.Add(this.ReceivingAddressTextBox);
            this.Controls.Add(this.SendingAddressTextBox);
            this.Controls.Add(this.AmountMinerFeesLabel);
            this.Controls.Add(this.AmountEOTLabel);
            this.Controls.Add(this.SendToLabel);
            this.Controls.Add(this.SendFromLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendEOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send EOT Coins";
            this.Load += new System.EventHandler(this.SendEOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SendFromLabel;
        private System.Windows.Forms.Label SendToLabel;
        private System.Windows.Forms.Label AmountEOTLabel;
        private System.Windows.Forms.Label AmountMinerFeesLabel;
        private System.Windows.Forms.TextBox SendingAddressTextBox;
        private System.Windows.Forms.TextBox AmountEOTtextbox;
        private System.Windows.Forms.TextBox EstimateAmountDollarTextBox;
        private System.Windows.Forms.Label EstimateEOTDollarValue;
        private System.Windows.Forms.TextBox MinerFeesTextBox;
        private System.Windows.Forms.TextBox EstimateMinerFeeDollarTextBox;
        private System.Windows.Forms.Label EstimateMinerFeeDollars;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox ReceivingAddressTextBox;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}