using System;
using System.IO;
using System.Windows.Forms;

namespace EOTCoinDesktopWallet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filename = "wallet.eot";
            Console.WriteLine(filename);

            string path = @"" + filename;
            if (File.Exists(path)) //if set up already 
            {
                Application.Run(new Login()); //password prompt to log in
            }
            else
            {
                Application.Run(new NewUser());
            }
        }

       
    }
}
