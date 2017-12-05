using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show();

            this.Hide();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;

            string eotSeed = Utilities.FileDecrypt("wallet.eot", password);

            string txtAddress = Utilities.readTxtFile();

            List<string> keyPair = Utilities.getKeyPair(eotSeed);
            string eotPrivateKey = keyPair.ElementAt(0);
            string eotAddress = keyPair.ElementAt(1);
            Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, eotSeed);

            if (eotWallet.eotAddress == txtAddress)
            {
                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;

                
                seedLabel.Text = "Please keep this wallet seed safe \nIf someone gets your wallet seed they can steal your coins";
                seedLabel.ForeColor = Color.FromArgb(255, 0, 0);
                seedLabel.Visible = true;

                seedTextBox.Text = eotWallet.eotSeed;
                seedTextBox.Visible = true;

                ExportButton.Visible = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
            }
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
