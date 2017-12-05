using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class EOTCoinWalletDashboard : Form
    {
        Thread t;
        public EOTCoinWalletDashboard()
        {
            string address = "";
            string path = @"Address.txt";
            if (File.Exists(path))
            {
                address = File.ReadLines(path).First();
            }

            InitializeComponent();

            

            AddressLabel.Text = address;
            BalanceLabel2.Text = Utilities.GetAddressBalance(AddressLabel.Text).ToString();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void EOTCoinWalletDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendEOT sendeotform = new SendEOT();
            sendeotform.Show();

            this.Hide();
        }


        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            Transactions txnform = new Transactions();
            txnform.Show();

            this.Hide();           
        }

        private void ReceieveButton_Click(object sender, EventArgs e)
        {
            ReceiveEOT receiveeotform = new ReceiveEOT();
            receiveeotform.Show();

            this.Hide();
        }
        

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();

            this.Hide();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(AddressLabel.Text);
            System.Windows.Forms.MessageBox.Show("Copied to clipboard!");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboard = new EOTCoinWalletDashboard();
            dashboard.Show();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal balance = Utilities.GetAddressBalance(AddressLabel.Text);
            BalanceLabel2.Text = balance.ToString() + " EOT";
        }
    }
}
