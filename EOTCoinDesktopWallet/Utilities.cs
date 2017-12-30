using NBitcoin;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace EOTCoinDesktopWallet
{
    class Utilities
    {
        const string fileName = "wallet.eot";
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static string generateSeed(string inputString, Random rnd)
        {
            string seed = "";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputString);

            char[] chars = {'A','B','C' ,'D' ,'E' ,'F' ,'G' ,'H' ,'I' ,'J' ,'K' ,'L' ,
            'M' ,'N' ,'O' ,'P' ,'Q' ,'R' ,'S' ,'T' ,'U' ,'V' ,'W' ,'X' ,'Y' ,'Z' ,
            'a' ,'b' ,'c' ,'d' ,'e' ,'f' ,'g' ,'h' ,'i' ,'j' ,'k' ,'l' ,'m' ,'n' ,
            'o' ,'p' ,'q' ,'r' ,'s' ,'t' ,'u' ,'v' ,'w' ,'x' ,'y' ,'z' ,
            '0' ,'1' ,'2' ,'3' ,'4' ,'5' ,'6' ,'7' ,'8' ,'9'};

            for (int i = 0; i <= 120; i++)
            {
                int x = rnd.Next(0, 62); 
                int second = DateTime.Now.Second; 

                int charAt = (x + second) / 2; 

                int value = asciiBytes[charAt]; 
                
                do
                {
                    value = value / 2;
                }
                while (value > 62);

                seed += chars[value];
            }
            
            return seed;
        }

        public static List<string> getKeyPair(string seedString)
        {
            List<string> keyPair = new List<string>();
            byte[] seed = ASCIIEncoding.ASCII.GetBytes(seedString);

            NBitcoin.ExtKey key = new ExtKey(seed);
            string eotprivatekey = key.PrivateKey.GetWif(Network.EOTNet).ToString();
            string eotaddress = key.PrivateKey.PubKey.GetAddress(Network.EOTNet).ToString();

            keyPair.Add(eotprivatekey);
            keyPair.Add(eotaddress);

            return keyPair;
        }

        public static decimal GetAddressBalance(string bitcoinAddress)
        {
            string ApiBaseAddressForEOT = "http://178.62.30.50:3622/api";
            int RoundInt = 8;
            try
            {
                string URL = ApiBaseAddressForEOT + "/addr/" + bitcoinAddress + "/?noTxList=1";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response1 = client.GetAsync(URL).Result;
                // Blocking call!
                if (response1.IsSuccessStatusCode)
                {
                    var dataObjects = response1.Content.ReadAsStringAsync().Result;
                    var json = JObject.Parse(dataObjects);
                    decimal AddressAmount = Math.Round(Convert.ToDecimal(json["balance"]), RoundInt);//+ Convert.ToDouble(json["unconfirmedBalance"]
                    return AddressAmount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside AddressAmountMethod");
                Console.WriteLine("Exception in AddressAmountUsingPrimaryAPI Method" + ex.ToString());
            }
            return 0;
        }

        public static bool CheckInternetConnectivity()
        {
            try
            {
                int description;
                return InternetGetConnectedState(out description, 0);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        public static void WriteWalletDat(Wallet wallet)
        {
            String seed = wallet.eotSeed.ToString();
            String priKey = wallet.eotPrivateKey.ToString();
            String address = wallet.eotAddress.ToString();
            
            byte[] arr = System.Text.Encoding.UTF8.GetBytes(seed);
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(arr);
            }

            string password = "ThePasswordToDecryptAndEncryptTheFile";

            // For additional security Pin the password of your files
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            // Encrypt the file

            Utilities.FileEncrypt(@"WalleDetails.txt", password);

            // To increase the security of the encryption, delete the given password from the memory !
            ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
            gch.Free();

            // You can verify it by displaying its value later on the console (the password won't appear)
            Console.WriteLine("The given password is surely nothing: " + password);
        }

        public static void printWalletToFile(Wallet wallet)
        {
            string address = wallet.eotAddress.ToString();

            string filename = "Address";
            filename.Replace(" ", "");
            filename = filename + ".txt";
            
            string path = @"" + filename;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(address);
                tw.Close();
            }
        }

        public static List<TransactionHistoryEOT> GetEOTTransactionInfo(string eotaddress)
        {
            List<TransactionHistoryEOT> listtrans = new List<TransactionHistoryEOT>();
            string ApiBaseAddressForEOT = "http://178.62.30.50:3622/api";
            int RoundInt = 8;

            decimal amountsumvin = 0;
            decimal amountsumvout = 0;
            decimal amountsum = 0;
            decimal pendingbal = 0;
            listtrans.Clear();
            string URL = ApiBaseAddressForEOT + "/txs?address=" + eotaddress;
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response1 = client.GetAsync(URL).Result;  // Blocking call!
                if (response1.IsSuccessStatusCode)
                {

                    var dataObjects = response1.Content.ReadAsStringAsync().Result;
                    var json = JObject.Parse(dataObjects);
                    foreach (var txn in json["txs"])
                    {
                        amountsumvin = 0;
                        amountsumvout = 0;
                        amountsum = 0;
                        TransactionHistoryEOT history = new TransactionHistoryEOT();
                        history.TransactionId = txn["txid"].ToString();
                        if (txn["time"] != null)
                        {
                            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(new System.DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Convert.ToDouble(txn["time"])), TimeZoneInfo.Local);
                            history.Date = cstTime;
                        }
                        else
                        {
                            history.Date = DateTime.Now;
                        }
                        try
                        {
                            foreach (var liaddrs in txn["vin"])
                            {
                                if (liaddrs["addr"].ToString() == eotaddress)
                                {
                                    amountsumvin = amountsumvin + Convert.ToDecimal(Convert.ToDecimal(liaddrs["value"]).ToString("0.########"));
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Inside GetEOTTransactionInfo VIN Method");
                            Console.WriteLine("Exception in GetEOTTransactionInfo VIN Method" + ex.ToString());
                        }
                        try
                        {
                            foreach (var liaddrs in txn["vout"])
                            {
                                foreach (var address in liaddrs["scriptPubKey"]["addresses"])
                                {
                                    if (address.ToString() == eotaddress)
                                    {
                                        amountsumvout = amountsumvout + Convert.ToDecimal(Convert.ToDecimal(liaddrs["value"]).ToString("0.########"));
                                    }
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Inside GetEOTTransactionInfo VOUT Method");
                            Console.WriteLine("Exception in GetEOTTransactionInfo VOUT Method" + ex.ToString());

                        }
                        amountsum = (amountsumvout - amountsumvin);
                        var r = Math.Round(amountsum, RoundInt);
                        if (amountsum < 0)
                        {
                            history.Type = 0.ToString(); //sent
                        }

                        else
                        {
                            history.Type = 1.ToString(); //received
                        }

                        history.Amount = Math.Abs(Convert.ToDecimal(amountsum.ToString("0.########")));
                        if (Convert.ToInt64(txn["confirmations"]) > 0)
                        {
                            history.TxStatus = "Confirm";
                        }
                        else
                        {
                            history.TxStatus = "Pending";
                            if (history.Type == 0.ToString())
                            {
                                pendingbal = pendingbal + history.Amount;
                            }
                        }
                        history.Address = GetTxns(txn, history.Type, eotaddress);
                        history.TransactionFees = Convert.ToDecimal(txn["fees"]);

                        listtrans.Add(history);
                    }
                    return listtrans;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside GetTransactionInfoUsingPrimaryAPI Method");
                Console.WriteLine("Exception in GetTransactionInfoUsingPrimaryAPI Method" + ex.ToString());
            }
            return null;

        }

        public static string[] GetTxns(JToken json, string Txtype, string addresstrans)
        {
            string[] list = new string[100];

            try
            {
                int i = 0;
                if (Txtype == "Receive")
                {
                    foreach (var txn in json["vin"])
                    {
                        if (txn["addr"].ToString() != addresstrans)
                        {
                            list[i] = txn["addr"].ToString();
                            i++;
                        }
                    }
                }
                else
                {
                    foreach (var txn in json["vout"])
                    {

                        foreach (var address in txn["scriptPubKey"]["addresses"])
                        {
                            if (address.ToString() != addresstrans)
                            {
                                list[i] = address.ToString();
                                i++;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;
        }

        /// <summary>
        /// Creates a random salt that will be used to encrypt your file. This method is required on FileEncrypt.
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        /// <summary>
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="password"></param>
        public static void FileEncrypt(string seed, string password)
        {
            byte[] salt = GenerateRandomSalt();
            
            FileStream fsCrypt = new FileStream("wallet.eot", FileMode.Create);
            
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;
            
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            
            byte [] buffer = ASCIIEncoding.ASCII.GetBytes(seed);
            int read = buffer.Length;

            try
            {
                    cs.Write(buffer, 0, read);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        public static void FileEncryptPassWordVault(string seed, byte[] password)
        {
            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream("passwordvault.eot", FileMode.Create);

            //  byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] passwordBytes = password;

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(seed);
            int read = buffer.Length;

            try
            {
                cs.Write(buffer, 0, read);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        public static void FileEncryptPassWordVault2(string seed, string password)
        {
            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream("transaction.eot", FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(seed);
            int read = buffer.Length;

            try
            {
                cs.Write(buffer, 0, read);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        public static string FileDecrypt(string inputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            

            int read;
            byte[] buffer = new byte[121];
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsCrypt.Close();
            }
            string seed = System.Text.ASCIIEncoding.Default.GetString(buffer);
            return seed;
        }

        public static string FileDecrypt2(string inputFile, byte[] password)
        {
            byte[] passwordBytes = password;//System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);


            int read;
            byte[] buffer = new byte[121];
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsCrypt.Close();
            }
            string seed = System.Text.ASCIIEncoding.Default.GetString(buffer);
            return seed;
        }

        public static string readTxtFile()
        {
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

            return txtAddress;
        }

        public static  decimal ExchangeRates()
        {
            string URL = "https://api.coinmarketcap.com/v1/ticker/";
            HttpResponseMessage response;
            decimal ConvertAmount = 0;
            try
            {
                // Thread.Sleep(3000);
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
                
                URL = URL + "eot-token";
                  

                // List data response.
                response = client.GetAsync(URL).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        // Parse the response body. Blocking!
                        var dataObjects = response.Content.ReadAsStringAsync().Result;
                        var json = JArray.Parse(dataObjects);
                        ConvertAmount = Convert.ToDecimal(json[0]["price_usd"]);
                        ConvertAmount = 1 / ConvertAmount;
                    }
                    catch (Exception ex)
                    {

                    }
                    return ConvertAmount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
