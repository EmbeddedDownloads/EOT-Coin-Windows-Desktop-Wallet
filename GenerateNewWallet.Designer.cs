namespace EOTCoinDesktopWallet
{
    partial class GenerateNewWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateNewWallet));
            this.randcharslabel = new System.Windows.Forms.Label();
            this.randcharstextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.remaininglabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectedPictureBox = new System.Windows.Forms.PictureBox();
            this.ConnectedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // randcharslabel
            // 
            this.randcharslabel.AutoSize = true;
            this.randcharslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randcharslabel.Location = new System.Drawing.Point(33, 106);
            this.randcharslabel.Name = "randcharslabel";
            this.randcharslabel.Size = new System.Drawing.Size(422, 29);
            this.randcharslabel.TabIndex = 0;
            this.randcharslabel.Text = "Please enter 120 random characters";
            // 
            // randcharstextBox
            // 
            this.randcharstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.randcharstextBox.Location = new System.Drawing.Point(38, 156);
            this.randcharstextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randcharstextBox.Name = "randcharstextBox";
            this.randcharstextBox.Size = new System.Drawing.Size(439, 36);
            this.randcharstextBox.TabIndex = 1;
            this.randcharstextBox.TextChanged += new System.EventHandler(this.randcharstextBox_TextChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(38, 257);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(188, 40);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // remaininglabel
            // 
            this.remaininglabel.AutoSize = true;
            this.remaininglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaininglabel.Location = new System.Drawing.Point(33, 214);
            this.remaininglabel.Name = "remaininglabel";
            this.remaininglabel.Size = new System.Drawing.Size(299, 29);
            this.remaininglabel.TabIndex = 3;
            this.remaininglabel.Text = "120 characters remaining";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordBox.Location = new System.Drawing.Point(38, 57);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(294, 36);
            this.PasswordBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // DashboardButton
            // 
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.Location = new System.Drawing.Point(289, 257);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(188, 40);
            this.DashboardButton.TabIndex = 7;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Location = new System.Drawing.Point(396, 312);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(0, 17);
            this.ConnectedLabel.TabIndex = 8;
            // 
            // ConnectedPictureBox
            // 
            this.ConnectedPictureBox.Location = new System.Drawing.Point(448, 312);
            this.ConnectedPictureBox.Name = "ConnectedPictureBox";
            this.ConnectedPictureBox.Size = new System.Drawing.Size(30, 17);
            this.ConnectedPictureBox.TabIndex = 9;
            this.ConnectedPictureBox.TabStop = false;
            // 
            // ConnectedTimer
            // 
            this.ConnectedTimer.Enabled = true;
            this.ConnectedTimer.Interval = 1500;
            this.ConnectedTimer.Tick += new System.EventHandler(this.ConnectedTimer_Tick);
            // 
            // GenerateNewWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 335);
            this.Controls.Add(this.ConnectedPictureBox);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.remaininglabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.randcharstextBox);
            this.Controls.Add(this.randcharslabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateNewWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate EOT Coin Wallet";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randcharslabel;
        private System.Windows.Forms.TextBox randcharstextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label remaininglabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.PictureBox ConnectedPictureBox;
        private System.Windows.Forms.Timer ConnectedTimer;
    }
}