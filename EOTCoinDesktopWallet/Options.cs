using System;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();

            this.Hide();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportWallet import = new ImportWallet();
            import.Show();

            this.Hide();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show();

            this.Hide();
        }

        private void GenerateWalletButton_Click(object sender, EventArgs e)
        {
            GenerateNewWallet newWallet = new GenerateNewWallet();
            newWallet.Show();

            this.Hide();
        }
    }
}
