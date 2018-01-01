using NBitcoin;
using NBitcoin.DataEncoders;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class CryptoDoc : Form
    {
        public CryptoDoc()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboard = new EOTCoinWalletDashboard();
            dashboard.Show();

            this.Hide();
        }

        void EOTTransactionForFileEncryption(byte[] FileData, string filename)
        {
            //String TextToEncrypt = PasswordVaultText.String;
            String password = CryptoDocPassword.Text;
            string seed = Utilities.FileDecrypt("wallet.eot", password);
            string address = "";
            string path = "Address.txt";
            if (File.Exists(path))
            {
                address = File.ReadLines(path).First();
            }

            List<string> keyPair = Utilities.getKeyPair(seed);
            string eotPrivateKey = keyPair.ElementAt(0);
            string eotAddress = keyPair.ElementAt(1);
            Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);

            if (eotWallet.eotAddress == address) //password matches
            {
                if (File.Exists(filename + ".eot"))
                {

                    const string message = "You already have Encrypted data stored! If you continue this will overwrite your existing data!";
                    const string caption = "EOT Coin Wallet";
                    var clickresult = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    /*       var alert = new NSAlert()
                       {
                           AlertStyle = NSAlertStyle.Informational,
                           InformativeText = "You already have a File Encrypted with this name! If you continue this will overwrite your existing data!",
                           MessageText = "EOT Coin Wallet",
                       };
                       alert.AddButton("Continue");
                       alert.AddButton("Cancel");
                       var clickresult = alert.RunModal();
                       if (clickresult == 1000)*/
                    if (clickresult == DialogResult.Yes)
                    {
                        string receivingAddress = "EXHwHff6k6dvoreNtDBTCmjeuskChBF1H8";
                        decimal amount = 0.0m;
                        double minerFees = 0.001;
                        string vendorAddress = "EXHwHff6k6dvoreNtDBTCmjeuskChBF1H8"; //merchant address 
                        decimal transactionFees = 0.001m; //encryption fees
                        //check balance first
                        if (Utilities.GetAddressBalance(eotWallet.eotAddress) >= (amount + Convert.ToDecimal(minerFees)))
                        {
                            bool success = PerformEOTTransaction(eotWallet.eotPrivateKey, eotWallet.eotAddress, vendorAddress, transactionFees, receivingAddress, amount, minerFees);
                            if (success)
                            {
                               // var DataSource = new TransactionHistoryDataSource();
                                string[] arr = new string[7];
                                List<TransactionHistoryEOT> list = Utilities.GetEOTTransactionInfo(eotAddress);
                                for (int i = 0; i < list.Count(); i++)
                                {
                                    arr[0] = list.ElementAt(i).Date.ToString();
                                    // DateColumn.Value = arr[0];
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
                                    if (i == (list.Count() - 1))
                                    {
                                        Utilities.FileEncryptCryptoDoc(arr[5], password, filename + ".eott");
                                    }
                                   // DataSource.Transactions.Add(new TransactionHistory(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
                                    //itm = new ListViewItem(arr);
                                    //TransactionsView.Items.Add(itm);
                                }
                               // TransactionTable.DataSource = DataSource;
                                // ProductTable.DataSource = DataSource;
                                //TransactionTable.Delegate = new TransactionHistoryDelegate(DataSource);
                                //    ProductTable.Delegate = new ProductTableDelegate(DataSource);
                                byte[] encryption = File.ReadAllBytes(filename + ".eott");
                                //Utilities.FileEncryptPassWordVault(TextToEncrypt, encryption);
                                //PasswordVaultText.Value = File.ReadAllText("/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/passwordvault.eot");
                                Utilities.FileEncryptCryptoDocFile(FileData, encryption, filename);
                                System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet");
                                /* var alert2 = new NSAlert()
                                 {
                                     AlertStyle = NSAlertStyle.Informational,
                                     InformativeText = "EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet",
                                     MessageText = "EOT Coin Wallet",
                                 };
                                 alert2.RunModal();*/
                                CryptoDocPassword.Text = "";
                                //PasswordVaultPassword.StringValue = "";
                                
                                if (DeleteOriginal.CheckState == CheckState.Checked)
                                {
                                    File.Delete(filename);
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this");
                               /* var alert3 = new NSAlert()
                                {
                                    AlertStyle = NSAlertStyle.Informational,
                                    InformativeText = "EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ",
                                    MessageText = "EOT Coin Wallet",
                                };
                                alert3.RunModal();*/
                            }

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Not enough funds to process transaction!");
                           /* var alert4 = new NSAlert()
                            {
                                AlertStyle = NSAlertStyle.Informational,
                                InformativeText = "Not enough funds to process transaction!",
                                MessageText = "EOT Coin Wallet",
                            };
                            alert4.RunModal();*/
                        }
                        // System.Windows.Forms.MessageBox.Show("Not enough funds to process transaction!");
                    }
                }
                else
                {
                    string receivingAddress = "EXHwHff6k6dvoreNtDBTCmjeuskChBF1H8";
                    decimal amount = 0.0m;
                    double minerFees = 0.001;
                    string vendorAddress = "EXHwHff6k6dvoreNtDBTCmjeuskChBF1H8"; //merchant address 
                    decimal transactionFees = 0.001m; //encryption fees
                    //check balance first
                    if (Utilities.GetAddressBalance(eotWallet.eotAddress) >= (amount + Convert.ToDecimal(minerFees)))
                    {
                        bool success = PerformEOTTransaction(eotWallet.eotPrivateKey, eotWallet.eotAddress, vendorAddress, transactionFees, receivingAddress, amount, minerFees);
                        if (success)
                        {
                           // var DataSource = new TransactionHistoryDataSource();
                            string[] arr = new string[7];
                            List<TransactionHistoryEOT> list = Utilities.GetEOTTransactionInfo(eotAddress);
                            for (int i = 0; i < list.Count(); i++)
                            {
                                arr[0] = list.ElementAt(i).Date.ToString();
                                // DateColumn.Value = arr[0];
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
                                if (i == (list.Count() - 1))
                                {
                                    Utilities.FileEncryptCryptoDoc(arr[5], password, filename);
                                }
                               // DataSource.Transactions.Add(new TransactionHistory(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
                                //itm = new ListViewItem(arr);
                                //TransactionsView.Items.Add(itm);
                            }
                           // TransactionTable.DataSource = DataSource;
                            // ProductTable.DataSource = DataSource;
                           // TransactionTable.Delegate = new TransactionHistoryDelegate(DataSource);
                            //    ProductTable.Delegate = new ProductTableDelegate(DataSource);
                            byte[] encryption = File.ReadAllBytes(filename + ".eott");
                            //Utilities.FileEncryptPassWordVault(TextToEncrypt, encryption);
                            //PasswordVaultText.Value = File.ReadAllText("/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/passwordvault.eot");
                            Utilities.FileEncryptCryptoDocFile(FileData, encryption, filename);
                            System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet");
                            /*var alert = new NSAlert()
                            {
                                AlertStyle = NSAlertStyle.Informational,
                                InformativeText = "EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet",
                                MessageText = "EOT Coin Wallet",
                            };
                            alert.RunModal();*/
                            //PasswordVaultPassword.StringValue = "";
                            CryptoDocPassword.Text = "";
                            if (DeleteOriginal.CheckState == CheckState.Checked)
                            {
                                File.Delete(filename);
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this");
                            /*var alert = new NSAlert()
                            {
                                AlertStyle = NSAlertStyle.Informational,
                                InformativeText = "EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ",
                                MessageText = "EOT Coin Wallet",
                            };
                            alert.RunModal();*/
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough funds to process transaction!");
                      /*  var alert = new NSAlert()
                        {
                            AlertStyle = NSAlertStyle.Informational,
                            InformativeText = "Not enough funds to process transaction!",
                            MessageText = "EOT Coin Wallet",
                        };
                        alert.RunModal();*/
                    }
                    // System.Windows.Forms.MessageBox.Show("Not enough funds to process transaction!");                    
                }
            }
            else
            {
               /* var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Incorrect password!",
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();*/
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
            }
        }
        
        public bool PasswordCorrect(string password)
        {
            //String TextToEncrypt = PasswordVaultText.String;
            password = CryptoDocPassword.Text;
            string seed = Utilities.FileDecrypt("wallet.eot", password);
            string address = "";
            string path = "Address.txt";
            if (File.Exists(path))
            {
                address = File.ReadLines(path).First();
            }
            List<string> keyPair = Utilities.getKeyPair(seed);
            string eotPrivateKey = keyPair.ElementAt(0);
            string eotAddress = keyPair.ElementAt(1);
            Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
            if (eotWallet.eotAddress == address) //password matches
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PerformEOTTransaction(string bitcoinSecret, string senderAddress, string eotVendorAddress, decimal transactionFees, string receiverAddress, decimal amount, double minerfees)
        {
            bool result = false;
            try
            {
                //Transacion Builder handles the confirmations
                var me = BitcoinAddress.Create(senderAddress);
                TransactionBuilder builder = new TransactionBuilder();
                List<Coin> coins;
                coins = GetCoinList(senderAddress);
                Transaction transaction =
                    builder
                    .AddCoins(coins)
                    .AddKeys(new BitcoinSecret(bitcoinSecret))
                    .Send(BitcoinAddress.Create(receiverAddress), Money.Coins(amount))
                    .Send(BitcoinAddress.Create(eotVendorAddress), Money.Coins(transactionFees))
                    .SendFees(Money.Coins(Convert.ToDecimal(minerfees)))
                    .SetChange(me).BuildTransaction(true);

                result = PushTransaction(transaction.ToHex());
                return result;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Transaction Failed -- Colm testing: " + ex.Message);
                //Console.ReadKey();
            }
            return result;
        }

        public static List<Coin> GetCoinList(string address)
        {
            try
            {
                string ApiBaseAddressForEOT = "http://178.62.30.50:3622/api";
                string URL = ApiBaseAddressForEOT + "/addr/" + address + "/utxo";
                List<Coin> coins = new List<Coin>();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response1 = client.GetAsync(URL).Result;  // Blocking call!
                if (response1.IsSuccessStatusCode)
                {
                    var dataObjects = response1.Content.ReadAsStringAsync().Result;
                    var json = JArray.Parse(dataObjects);
                    foreach (var li in json)
                    {
                        {
                            var coin = new Coin(new
                            uint256(li["txid"].ToString()), Convert.ToUInt32(li["vout"]), Money.Satoshis(Convert.ToDecimal(li["amount"]) * 100000000), new
                            Script(Encoders.Hex.DecodeData(li["scriptPubKey"].ToString())));
                            coins.Add(coin);

                        }
                    }
                    return coins;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception in GetCoinListUsingPrimaryAPI method, Message : " + ex.Message);
            }
            return null;
        }

        public static bool PushTransaction(string hex)
        {
            try
            {
                HttpClient client = new HttpClient();
                string ApiBaseAddressForEOT = "http://178.62.30.50:3622/api";
                string URL = ApiBaseAddressForEOT + "/tx/send";
                var tx = "{\"rawtx\":" + "\"" + hex + "\"}";
                string _ContentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_ContentType));
                HttpContent _Body = new StringContent(tx);
                // and add the header to this object instance
                // optional: add a formatter option to it as well
                _Body.Headers.ContentType = new MediaTypeHeaderValue(_ContentType);
                // synchronous request without the need for .ContinueWith() or await
                var response = client.PostAsync(new Uri(URL), _Body).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.IsSuccessStatusCode;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Exception in PushTransaction method. :" + ex.ToString());
                return false;
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            /*base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }*/
        }

        private void EncryptFileButton_Click(object sender, EventArgs e)
        {
            if (PasswordCorrect(CryptoDocPassword.Text))
            {

                OpenFileDialog cryptoDocFileDialog = new OpenFileDialog();
                //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                cryptoDocFileDialog.Filter = "txt files (*.txt)|*.txt|pdf files (*.pdf)|*.pdf|docx files (*.docx)|*.docx|png files (*.png)|*.png";
                cryptoDocFileDialog.Title = "Select a File to Encrypt";
                cryptoDocFileDialog.FilterIndex = 4;
                
                if (cryptoDocFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileInfo fInfo = new System.IO.FileInfo(cryptoDocFileDialog.FileName);
                    string filename = fInfo.Name;
                    string path = fInfo.DirectoryName;
                    string fullpath = path + "//" + filename;
                    byte[] filedata = File.ReadAllBytes(fullpath);
                    EOTTransactionForFileEncryption(filedata, fullpath);

                }

                /*   CryptoDocOpenFileDialog.
                   var dlg = NSOpenPanel.OpenPanel;
                   dlg.CanChooseFiles = true;
                   dlg.CanChooseDirectories = false;
                   dlg.AllowedFileTypes = new string[] { "txt", "jpg", "pdf", "docx", "xlsx", "png" };
                   if (dlg.RunModal() == 1)
                   {
                       // Nab the first file
                       var url = dlg.Urls[0];
                       if (url != null)
                       {
                           var path = url.Path;
                           byte[] filedata = File.ReadAllBytes(path);
                           string filename = Path.GetFileName(path);
                           EOTTransactionForFileEncryption(filedata, path);
                           // Create a new window to hold the text
                           //  var newWindowController = new MainWindowController();
                           //  newWindowController.Window.MakeKeyAndOrderFront(this);
                           // Load the text into the window
                           //var window = newWindowController.Window as MainWindow;
                           // window.Text = File.ReadAllText(path);
                           //window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
                           //window.RepresentedUrl = url;
                       }
                   }*/
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
            }
        }

        private void CyptoDocDecryptButton_Click(object sender, EventArgs e)
        {
            if (PasswordCorrect(CryptoDocPassword.Text))
            {
                OpenFileDialog cryptoDocFileDialog = new OpenFileDialog();
                //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                cryptoDocFileDialog.Filter = "eot files (*.eot)|*.eot";
                cryptoDocFileDialog.Title = "Select a File to Decrypt";
                cryptoDocFileDialog.FilterIndex = 1;

                if (cryptoDocFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileInfo fInfo = new System.IO.FileInfo(cryptoDocFileDialog.FileName);
                    string filename = fInfo.Name;
                    string path = fInfo.DirectoryName;
                    string fullpath = path + "//" + filename;
                    byte[] filedata = File.ReadAllBytes(fullpath);
                    byte[] decryption = File.ReadAllBytes(fullpath + "t");
                    string abc = Utilities.FileDecrypt3(fullpath, decryption);
                    CryptoDocPassword.Text = "";
                    if (DeleteEncrypted.CheckState == CheckState.Checked)
                    {
                        File.Delete(fullpath);
                        File.Delete(fullpath + "t");
                    }
                    System.Windows.Forms.MessageBox.Show("Decryption Processed!");

                }
            }
            else
            {
                /* var alert = new NSAlert()
                 {
                     AlertStyle = NSAlertStyle.Informational,
                     InformativeText = "Incorrect password!",
                     MessageText = "EOT Coin Wallet",
                 };
                 alert.RunModal();*/
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    