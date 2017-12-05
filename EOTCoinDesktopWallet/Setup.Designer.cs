namespace EOTCoinDesktopWallet
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.EOTCoinWalletLabel = new System.Windows.Forms.Label();
            this.EOTPictureBox = new System.Windows.Forms.PictureBox();
            this.GetStartedButton = new System.Windows.Forms.Button();
            this.RandomCharsLabel = new System.Windows.Forms.Label();
            this.RandomCharsTextBox = new System.Windows.Forms.TextBox();
            this.remaininglabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EOTPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EOTCoinWalletLabel
            // 
            this.EOTCoinWalletLabel.AutoSize = true;
            this.EOTCoinWalletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EOTCoinWalletLabel.Location = new System.Drawing.Point(273, -2);
            this.EOTCoinWalletLabel.Name = "EOTCoinWalletLabel";
            this.EOTCoinWalletLabel.Size = new System.Drawing.Size(271, 39);
            this.EOTCoinWalletLabel.TabIndex = 0;
            this.EOTCoinWalletLabel.Text = "EOT Coin Wallet";
            // 
            // EOTPictureBox
            // 
            this.EOTPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EOTPictureBox.Image")));
            this.EOTPictureBox.Location = new System.Drawing.Point(609, 11);
            this.EOTPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EOTPictureBox.Name = "EOTPictureBox";
            this.EOTPictureBox.Size = new System.Drawing.Size(269, 252);
            this.EOTPictureBox.TabIndex = 1;
            this.EOTPictureBox.TabStop = false;
            // 
            // GetStartedButton
            // 
            this.GetStartedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedButton.Location = new System.Drawing.Point(340, 325);
            this.GetStartedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetStartedButton.Name = "GetStartedButton";
            this.GetStartedButton.Size = new System.Drawing.Size(259, 54);
            this.GetStartedButton.TabIndex = 2;
            this.GetStartedButton.Text = "Get started!";
            this.GetStartedButton.UseVisualStyleBackColor = true;
            this.GetStartedButton.Click += new System.EventHandler(this.GetStartedButton_Click);
            // 
            // RandomCharsLabel
            // 
            this.RandomCharsLabel.AutoSize = true;
            this.RandomCharsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RandomCharsLabel.Location = new System.Drawing.Point(3, 176);
            this.RandomCharsLabel.Name = "RandomCharsLabel";
            this.RandomCharsLabel.Size = new System.Drawing.Size(565, 39);
            this.RandomCharsLabel.TabIndex = 3;
            this.RandomCharsLabel.Text = "Please enter 120 random characters";
            // 
            // RandomCharsTextBox
            // 
            this.RandomCharsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomCharsTextBox.Location = new System.Drawing.Point(11, 217);
            this.RandomCharsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomCharsTextBox.Name = "RandomCharsTextBox";
            this.RandomCharsTextBox.Size = new System.Drawing.Size(588, 45);
            this.RandomCharsTextBox.TabIndex = 4;
            this.RandomCharsTextBox.TextChanged += new System.EventHandler(this.RandomCharsTextBox_TextChanged);
            // 
            // remaininglabel
            // 
            this.remaininglabel.AutoSize = true;
            this.remaininglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.remaininglabel.Location = new System.Drawing.Point(89, 266);
            this.remaininglabel.Name = "remaininglabel";
            this.remaininglabel.Size = new System.Drawing.Size(383, 39);
            this.remaininglabel.TabIndex = 5;
            this.remaininglabel.Text = "120 character remaining";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(3, 87);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(167, 39);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(189, 87);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(409, 45);
            this.PasswordBox.TabIndex = 7;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 409);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.remaininglabel);
            this.Controls.Add(this.RandomCharsTextBox);
            this.Controls.Add(this.RandomCharsLabel);
            this.Controls.Add(this.GetStartedButton);
            this.Controls.Add(this.EOTPictureBox);
            this.Controls.Add(this.EOTCoinWalletLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOT Wallet Setup";
            ((System.ComponentModel.ISupportInitialize)(this.EOTPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EOTCoinWalletLabel;
        private System.Windows.Forms.PictureBox EOTPictureBox;
        private System.Windows.Forms.Button GetStartedButton;
        private System.Windows.Forms.Label RandomCharsLabel;
        private System.Windows.Forms.TextBox RandomCharsTextBox;
        private System.Windows.Forms.Label remaininglabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}