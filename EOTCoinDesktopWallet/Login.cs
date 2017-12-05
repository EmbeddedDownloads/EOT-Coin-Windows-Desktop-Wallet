using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = PasswordBox.Text;

                string seed = Utilities.FileDecrypt("wallet.eot", password);
                string txtAddress = "";
                string filename = "Address.txt";
                string path = @"" + filename;
                if (File.Exists(path))
                {
                    txtAddress = File.ReadLines(path).First();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Address.txt does not exist!");
                }

                //generate address using seed
                List<string> keyPair = Utilities.getKeyPair(seed);
                string eotPrivateKey = keyPair.ElementAt(0);
                string eotAddress = keyPair.ElementAt(1);
                Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);

                //if address matches address.txt, go to dashboard
                if (txtAddress == eotWallet.eotAddress)
                {
                    EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
                    dashboardform.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect password, please try again!");
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Login failed: " + ex.Message);
            }
            
        }
    }
}
