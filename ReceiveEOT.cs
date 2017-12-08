using System;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class ReceiveEOT : Form
    {
        public ReceiveEOT()
        {
            string address = Utilities.readTxtFile();
            InitializeComponent();
            addressLabel.Text = address;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            QRCodePictureBox.Image = qrcode.Draw(addressLabel.Text, 55);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show(); 

            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendEOT sendeotform = new SendEOT();
            sendeotform.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CopyClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(addressLabel.Text);
            System.Windows.Forms.MessageBox.Show("Copied to clipboard!");
        }
        

        private void ScanLabel_Click(object sender, EventArgs e)
        {

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
