using System;
using System.Text;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;
using BlockChainCourse.Cryptography;

namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public class Transaction : ITransaction
    {
        public string MNV { get; set; }
        public string MaSach { get; set; }
        public DateTime TGMuon { get; set; }
        public double ChiPhi { get; set; }
        public DateTime TGTra { get; set; }
        public string NguoiMuon { get; set; }
        public ClaimType ClaimType { get; set; }
        public override string ToString()
        {
            return string.Format("{0}S{1}S{2}S{3}S{4}S{5}",MNV,MaSach,NguoiMuon,TGMuon,TGTra,ChiPhi);
        }
        public Transaction(string a,string b, String c, DateTime d, DateTime e,double f, ClaimType g)
        {
            MNV = a;
            MaSach = b;
            NguoiMuon = c;
            TGMuon = d;
            TGTra = e;
            ChiPhi = f;
            ClaimType = g;
        }
        public Transaction(string readFromFile)
        {
            string[] arr = readFromFile.Split(new char[] { (char)ConsoleKey.S }, StringSplitOptions.RemoveEmptyEntries);
            this.MNV = arr[0];
            this.MaSach = arr[1];
            this.NguoiMuon = arr[2];
            this.TGMuon = Convert.ToDateTime(arr[3]);
            this.TGTra = Convert.ToDateTime(arr[4]);
            this.ChiPhi = Convert.ToDouble(arr[5]);
            this.ClaimType = ClaimType.TotalLoss;
        }

        public string CalculateTransactionHash()
        {
            string txnHash = MNV+MaSach+ NguoiMuon + TGMuon + TGTra +ChiPhi +ClaimType;
            return Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(txnHash)));
        }
    }
}