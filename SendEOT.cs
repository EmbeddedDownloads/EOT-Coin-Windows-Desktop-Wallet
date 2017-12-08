using NBitcoin;
using NBitcoin.DataEncoders;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    public partial class SendEOT : Form
    {
        public SendEOT()
        {
            string sendingAddress = Utilities.readTxtFile();
            InitializeComponent();
            SendingAddressTextBox.Text = sendingAddress;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
            if(ReceivingAddressTextBox.Text != " " && ReceivingAddressTextBox != null)
            {
                if(AmountEOTtextbox.Text != "" && AmountEOTtextbox.Text != " " && AmountEOTtextbox.Text != null) //check if amount and miner fees are numeric
                {
                    if(MinerFeesTextBox.Text != " " && MinerFeesTextBox.Text != null)
                    {
                        if(PasswordTextBox.Text != " " && PasswordTextBox.Text != null)
                        {
                            Send();
                        }
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("You must enter an amount of miner fees to send!");
                }
                else
                    System.Windows.Forms.MessageBox.Show("You must enter an amount of EOT coins to send!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Receiving address must not be empty!");
            }
        }

        public void Send()
        {
            string password = PasswordTextBox.Text;
            string seed = Utilities.FileDecrypt("wallet.eot", password);

            List<string> keyPair = Utilities.getKeyPair(seed);
            string eotPrivateKey = keyPair.ElementAt(0);
            string eotAddress = keyPair.ElementAt(1);
            Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);

            if(eotWallet.eotAddress == SendingAddressTextBox.Text) //password matches
            {
                string receivingAddress = ReceivingAddressTextBox.Text;
                decimal amount = Convert.ToDecimal(AmountEOTtextbox.Text);
                double minerFees = Convert.ToDouble(MinerFeesTextBox.Text);
                string vendorAddress = "EerE2Vp8M4RAypufWsDZ3UHvQphHy99R1Q"; //merchant address 
                decimal transactionFees = 0.000m; //no transaction fee applied

                //check balance first
                if (Utilities.GetAddressBalance(eotWallet.eotAddress) >= (amount + Convert.ToDecimal(minerFees) + transactionFees))
                {
                    bool success =  PerformEOTTransaction(eotWallet.eotPrivateKey, eotWallet.eotAddress, vendorAddress, transactionFees, receivingAddress, amount, minerFees);
                    if (success)
                    {
                        System.Windows.Forms.MessageBox.Show("Transaction successfully processed!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Transaction failed: Not enough funds to process transaction!");
                    }                                   
                }
                else
                    System.Windows.Forms.MessageBox.Show("Not enough funds to process transaction!");
            }
            else
            {
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

        private void ReceivingAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            dashboardform.Show();

            this.Hide();
        }

        private void SendEOT_Load(object sender, EventArgs e)
        {

        }

        private void AmountEOTtextbox_TextChanged(object sender, EventArgs e)
        {
                try
                {
                    string amounttext = AmountEOTtextbox.Text;
                    decimal amounteot = Convert.ToDecimal(amounttext);
                    decimal exchange = Utilities.ExchangeRates();
                    decimal usd = amounteot / exchange;
                    EstimateAmountDollarTextBox.Text = usd.ToString();
                }
                catch (Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show("Amount must the numberic");
                }          
        }

        private void MinerFeesTextBox_TextChanged(object sender, EventArgs e)
        {
                try
                {
                    string amountminerfees = MinerFeesTextBox.Text;
                    decimal amounteot = Convert.ToDecimal(amountminerfees);
                    decimal exchange = Utilities.ExchangeRates();
                    decimal usd = amounteot / exchange;
                    EstimateMinerFeeDollarTextBox.Text = usd.ToString();
                }
                catch (Exception ex)
                {
                 //   System.Windows.Forms.MessageBox.Show("Amount must the numberic");
                }
            
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
