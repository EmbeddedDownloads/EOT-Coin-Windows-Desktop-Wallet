using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class GenerateNewWallet : Form
    {
        public GenerateNewWallet()
        {
            InitializeComponent();
            string filename = "Address";
            filename.Replace(" ", "");
            filename = filename + ".txt";

            string path = @"" + filename;
            if (File.Exists(path))
            {
                System.Windows.Forms.MessageBox.Show("WARNING: Please note importing a new wallet will overwrite your existing wallet.");
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (randcharstextBox.Text.Length < 120)
            {
                System.Windows.Forms.MessageBox.Show("Please enter 120 random characters");
            }
            else
            {
                string inputString = randcharstextBox.Text;
                String Password = PasswordBox.Text;

                Random rnd = new Random();
                string seed = Utilities.generateSeed(inputString, rnd);

                List<string> keyPair = Utilities.getKeyPair(seed);
                string eotPrivateKey = keyPair.ElementAt(0);
                string eotAddress = keyPair.ElementAt(1);

                Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
                Utilities.FileEncrypt(seed, Password);
                Utilities.printWalletToFile(eotWallet);

                EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
                dashboardform.Show();

                this.Hide();
            }
        }

        private void randcharstextBox_TextChanged(object sender, EventArgs e)
        {
            int count = randcharstextBox.Text.Length;
            int remaining = 120 - count;
            if (remaining > 0)
            {
                remaininglabel.Text = remaining + " characters remaining";
            }
            else
            {
                remaininglabel.Text = "You can generate a wallet now!";
            }   
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show();

            this.Hide();
        }
    }
}
