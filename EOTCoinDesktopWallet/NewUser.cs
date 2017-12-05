using System;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportWallet import = new ImportWallet();
            import.Show();

            this.Hide();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();

            this.Hide();
        }
    }
}
