namespace EOTCoinDesktopWallet
{
    partial class ImportWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWallet));
            this.PleaseEnterLabel = new System.Windows.Forms.Label();
            this.SeedPriKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PleaseEnterLabel
            // 
            this.PleaseEnterLabel.AutoSize = true;
            this.PleaseEnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PleaseEnterLabel.Location = new System.Drawing.Point(12, 34);
            this.PleaseEnterLabel.Name = "PleaseEnterLabel";
            this.PleaseEnterLabel.Size = new System.Drawing.Size(359, 29);
            this.PleaseEnterLabel.TabIndex = 0;
            this.PleaseEnterLabel.Text = "Please enter your wallet seed: ";
            // 
            // SeedPriKeyTextBox
            // 
            this.SeedPriKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeedPriKeyTextBox.Location = new System.Drawing.Point(17, 95);
            this.SeedPriKeyTextBox.Name = "SeedPriKeyTextBox";
            this.SeedPriKeyTextBox.Size = new System.Drawing.Size(668, 36);
            this.SeedPriKeyTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please choose a password: ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordTextBox.Location = new System.Drawing.Point(17, 195);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(668, 36);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ImportButton.Location = new System.Drawing.Point(17, 248);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(105, 40);
            this.ImportButton.TabIndex = 5;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackButton.Location = new System.Drawing.Point(586, 248);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 40);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ImportWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 305);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeedPriKeyTextBox);
            this.Controls.Add(this.PleaseEnterLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Existing EOT Coin Wallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PleaseEnterLabel;
        private System.Windows.Forms.TextBox SeedPriKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button BackButton;
    }
}