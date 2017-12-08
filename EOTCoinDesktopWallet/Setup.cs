using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            
                if (RandomCharsTextBox.Text.Length < 120)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter 120 random characters");
                }
                else
                {
                    string Password = PasswordBox.Text;

                    string inputString = RandomCharsTextBox.Text;

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RandomCharsTextBox_TextChanged(object sender, EventArgs e)
        {
            int count = RandomCharsTextBox.Text.Length;
            int remaining = 120 - count;
            if (remaining > 0)
            {
                remaininglabel.Text = remaining + " characters remaining";
            }
            else
                remaininglabel.Text = "You can generate a wallet now!";
        }

        private void ConnectedTimer_Tick(object sender, EventArgs e)
        {
            bool connected = Utilities.CheckInternetConnectivity();

            if (connected)
            {
                ConnectedLabel.Text = "Online";
                ConnectedPictureBox.Image = EOTCoinDesktopWallet.Properties.Resources.online;
            }
            else
            {
                ConnectedLabel.Text = "Offline";
                ConnectedPictureBox.Image = EOTCoinDesktopWallet.Properties.Resources.offline;
            }
        }
    }
}
