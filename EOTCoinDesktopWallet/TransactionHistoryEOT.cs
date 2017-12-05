using System;

namespace EOTCoinDesktopWallet
{
    class TransactionHistoryEOT
    {
        public string TransactionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string TxStatus { get; set; }
        public string Type { get; set; }
        public decimal TransactionFees { get; set; }
        public string[] Address { get; set; }
    }
}
