using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            Transactions_Load();
        }

        private void Transactions_Load()
        {
            TransactionsView.View = View.Details;
            TransactionsView.GridLines = true;
            TransactionsView.FullRowSelect = true;

            //Add column header
            TransactionsView.Columns.Add("Date", 120);
            TransactionsView.Columns.Add("Amount", 70);
            TransactionsView.Columns.Add("Status", 60);
            TransactionsView.Columns.Add("Type", 75);
            TransactionsView.Columns.Add("From/To Address", 255);
            TransactionsView.Columns.Add("Transaction ID",255);

            //Add items in the listview
            string[] arr = new string[7];
            ListViewItem itm;
            EOTAddressLabel.Text = Utilities.readTxtFile();

            BalanceLabel2.Text = Utilities.GetAddressBalance(EOTAddressLabel.Text).ToString() + " EOT";

            List <TransactionHistoryEOT> list = Utilities.GetEOTTransactionInfo(EOTAddressLabel.Text);

            for(int i = 0; i < list.Count(); i++)
            {
                arr[0] = list.ElementAt(i).Date.ToString();
                arr[1] = list.ElementAt(i).Amount.ToString();
                arr[2] = list.ElementAt(i).TxStatus;

                if (list.ElementAt(i).Type == "0")
                {
                    arr[3] = "Sent";
                }
                else if (list.ElementAt(i).Type == "1")
                {
                    arr[3] = "Received";
                }

                //arr[3] = list.ElementAt(i).Type;
                arr[4] = list.ElementAt(i).Address[0];
                arr[5] = list.ElementAt(i).TransactionId;
                itm = new ListViewItem(arr);
                TransactionsView.Items.Add(itm);
            }
        }

        private void TransactionsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show();
            this.Hide();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendEOT sendeotform = new SendEOT(); 
            sendeotform.Show();

            this.Hide();
        }

        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            ReceiveEOT receive = new ReceiveEOT();
            receive.Show();

            this.Hide();
        }

        private void BalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Transactions txns = new Transactions();
            txns.Show();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal balance = Utilities.GetAddressBalance(EOTAddressLabel.Text);
            BalanceLabel2.Text = balance.ToString() + " EOT";
            Transactions_Load();
        }
    }
}
