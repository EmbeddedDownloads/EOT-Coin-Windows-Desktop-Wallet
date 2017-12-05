namespace EOTCoinDesktopWallet
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceLabel2 = new System.Windows.Forms.Label();
            this.TransactionsView = new System.Windows.Forms.ListView();
            this.ShowingLabel = new System.Windows.Forms.Label();
            this.EOTAddressLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BalanceLabel.Location = new System.Drawing.Point(559, 497);
            this.BalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(112, 29);
            this.BalanceLabel.TabIndex = 0;
            this.BalanceLabel.Text = "Balance:";
            this.BalanceLabel.Click += new System.EventHandler(this.BalanceLabel_Click);
            // 
            // BalanceLabel2
            // 
            this.BalanceLabel2.AutoSize = true;
            this.BalanceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BalanceLabel2.Location = new System.Drawing.Point(668, 497);
            this.BalanceLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLabel2.Name = "BalanceLabel2";
            this.BalanceLabel2.Size = new System.Drawing.Size(106, 29);
            this.BalanceLabel2.TabIndex = 1;
            this.BalanceLabel2.Text = "0.0 EOT";
            // 
            // TransactionsView
            // 
            this.TransactionsView.Location = new System.Drawing.Point(13, 59);
            this.TransactionsView.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionsView.Name = "TransactionsView";
            this.TransactionsView.Size = new System.Drawing.Size(998, 425);
            this.TransactionsView.TabIndex = 2;
            this.TransactionsView.UseCompatibleStateImageBehavior = false;
            this.TransactionsView.SelectedIndexChanged += new System.EventHandler(this.TransactionsView_SelectedIndexChanged);
            // 
            // ShowingLabel
            // 
            this.ShowingLabel.AutoSize = true;
            this.ShowingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowingLabel.Location = new System.Drawing.Point(13, 15);
            this.ShowingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowingLabel.Name = "ShowingLabel";
            this.ShowingLabel.Size = new System.Drawing.Size(304, 29);
            this.ShowingLabel.TabIndex = 3;
            this.ShowingLabel.Text = "Showing transactions for: ";
            // 
            // EOTAddressLabel
            // 
            this.EOTAddressLabel.AutoSize = true;
            this.EOTAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EOTAddressLabel.Location = new System.Drawing.Point(325, 15);
            this.EOTAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EOTAddressLabel.Name = "EOTAddressLabel";
            this.EOTAddressLabel.Size = new System.Drawing.Size(106, 29);
            this.EOTAddressLabel.TabIndex = 4;
            this.EOTAddressLabel.Text = "Address";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SendButton.Location = new System.Drawing.Point(13, 491);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(115, 40);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReceiveButton.Location = new System.Drawing.Point(136, 491);
            this.ReceiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(124, 40);
            this.ReceiveButton.TabIndex = 6;
            this.ReceiveButton.Text = "Receive";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DashboardButton.Location = new System.Drawing.Point(269, 491);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(162, 40);
            this.DashboardButton.TabIndex = 7;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RefreshButton.Location = new System.Drawing.Point(492, 491);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 35);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 545);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.ReceiveButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EOTAddressLabel);
            this.Controls.Add(this.ShowingLabel);
            this.Controls.Add(this.TransactionsView);
            this.Controls.Add(this.BalanceLabel2);
            this.Controls.Add(this.BalanceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOT Coin Wallet";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label BalanceLabel2;
        private System.Windows.Forms.ListView TransactionsView;
        private System.Windows.Forms.Label ShowingLabel;
        private System.Windows.Forms.Label EOTAddressLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Timer timer1;
    }
}