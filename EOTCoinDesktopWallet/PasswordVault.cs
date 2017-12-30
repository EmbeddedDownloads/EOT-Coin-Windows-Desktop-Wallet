using NBitcoin;
using NBitcoin.DataEncoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EOTCoinDesktopWallet
{
    public partial class PasswordVault : Form
    {
        public PasswordVault()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string TextToEncrypt = TextToEncryptBox.Text;
            string password = PasswordPasswordVault.Text;

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
                if (File.Exists("passwordvault.eot"))
                {
                
                    const string message = "You already have Encrypted data stored! If you continue this will overwrite your existing data!";
                    const string caption = "EOT Coin Wallet";
                    var clickresult = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

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
                                //var DataSource = new TransactionHistoryDataSource();
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
                                        Utilities.FileEncryptPassWordVault2(arr[5], password);
                                    }
                                   // DataSource.Transactions.Add(new TransactionHistory(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
                                    //itm = new ListViewItem(arr);
                                    //TransactionsView.Items.Add(itm);
                                }

                                //TransactionTable.DataSource = DataSource;
                                // ProductTable.DataSource = DataSource;
                                //TransactionTable.Delegate = new TransactionHistoryDelegate(DataSource);
                                //    ProductTable.Delegate = new ProductTableDelegate(DataSource);

                                byte[] encryption = File.ReadAllBytes("transaction.eot");
                                Utilities.FileEncryptPassWordVault(TextToEncrypt, encryption);
                                TextToEncryptBox.Text = File.ReadAllText("passwordvault.eot");

                                System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction processed!0.002 EOT Transaction fees withdrawn from your wallet");
                               /* var alert2 = new NSAlert()
                                {
                                    AlertStyle = NSAlertStyle.Informational,
                                    InformativeText = "EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet",
                                    MessageText = "EOT Coin Wallet",
                                };
                                alert2.RunModal();*/
                                PasswordPasswordVault.Text = "";

                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ");
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
                            System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ");
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
                            //var DataSource = new TransactionHistoryDataSource();
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
                                    Utilities.FileEncryptPassWordVault2(arr[5], password);
                                }
                                // DataSource.Transactions.Add(new TransactionHistory(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
                                //itm = new ListViewItem(arr);
                                //TransactionsView.Items.Add(itm);
                            }

                            //TransactionTable.DataSource = DataSource;
                            // ProductTable.DataSource = DataSource;
                            //TransactionTable.Delegate = new TransactionHistoryDelegate(DataSource);
                            //    ProductTable.Delegate = new ProductTableDelegate(DataSource);

                            byte[] encryption = File.ReadAllBytes("transaction.eot");
                            Utilities.FileEncryptPassWordVault(TextToEncrypt, encryption);
                            TextToEncryptBox.Text = File.ReadAllText("passwordvault.eot");

                            System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction processed!0.002 EOT Transaction fees withdrawn from your wallet");
                            /* var alert2 = new NSAlert()
                             {
                                 AlertStyle = NSAlertStyle.Informational,
                                 InformativeText = "EOT Encryption Transaction processed! 0.002 EOT Transaction fees withdrawn from your wallet",
                                 MessageText = "EOT Coin Wallet",
                             };
                             alert2.RunModal();*/
                            PasswordPasswordVault.Text = "";

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ");
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
                        System.Windows.Forms.MessageBox.Show("EOT Encryption Transaction failed: Not enough funds to process transaction! You need 0.002 EOT For this ");
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

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboard = new EOTCoinWalletDashboard();
            dashboard.Show();

            this.Hide();
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

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string password = PasswordPasswordVault.Text;

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
                if (File.Exists("transaction.eot"))
                {
                    byte[] decryption = File.ReadAllBytes("transaction.eot");
                    if (File.Exists("passwordvault.eot"))
                    {
                        TextToEncryptBox.Text = Utilities.FileDecrypt2("passwordvault.eot", decryption);
                        PasswordPasswordVault.Text = "";
                    }
                    else
                    {
                        /*var alert = new NSAlert()
                        {
                            AlertStyle = NSAlertStyle.Informational,
                            InformativeText = "You have no data encrypted!",
                            MessageText = "EOT Coin Wallet",
                        };
                        alert.RunModal();*/
                        System.Windows.Forms.MessageBox.Show("You have no data encrypted!");
                        PasswordPasswordVault.Text = "";
                    }

                }
                else
                {
                    /* var alert = new NSAlert()
                     {
                         AlertStyle = NSAlertStyle.Informational,
                         InformativeText = "You have no data encrypted!",
                         MessageText = "EOT Coin Wallet",
                     };
                     alert.RunModal();*/
                    System.Windows.Forms.MessageBox.Show("You have no data encrypted!");
                    PasswordPasswordVault.Text = "";
                }

            }
            else
            {
             /*   var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Incorrect password!",
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();*/
                System.Windows.Forms.MessageBox.Show("Incorrect password!");
                PasswordPasswordVault.Text = "";
            }
        }
    }
}
