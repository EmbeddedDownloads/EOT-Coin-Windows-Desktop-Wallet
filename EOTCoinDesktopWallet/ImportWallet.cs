using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class ImportWallet : Form
    {
        public ImportWallet()
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

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if(SeedPriKeyTextBox.Text != " " && SeedPriKeyTextBox.Text != null)
            {
                if(PasswordTextBox.Text != " " && PasswordTextBox.Text != null)
                {
                    import();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a password");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter your wallet seed");
            }
        }

        public void import()
        {
            try
            {
                string seed = SeedPriKeyTextBox.Text;
                string password = PasswordTextBox.Text;

                List<string> keyPair = Utilities.getKeyPair(seed);
                string eotPrivateKey = keyPair.ElementAt(0);
                string eotAddress = keyPair.ElementAt(1);
                Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
                
                string file1 = @"wallet.eot";
                string file2 = @"Address.txt";

                if (File.Exists(file1) && File.Exists(file2))
                {
                    File.Delete(file1);
                    File.Delete(file2);
                }

                Utilities.FileEncrypt(seed, password);
                Utilities.printWalletToFile(eotWallet);

                System.Windows.Forms.MessageBox.Show("Wallet imported successfully!");

                EOTCoinWalletDashboard dashboard = new EOTCoinWalletDashboard();
                dashboard.Show();

                this.Hide();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Import failed: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            string filename = "Address";
            filename.Replace(" ", "");
            filename = filename + ".txt";

            string path = @"" + filename;
            if (File.Exists(path))
            {
                Options options = new Options();
                options.Show();

                this.Hide();
            }
            else
            {
                NewUser newUser = new NewUser();
                newUser.Show();

                this.Hide();
            }
        }
    }
}
