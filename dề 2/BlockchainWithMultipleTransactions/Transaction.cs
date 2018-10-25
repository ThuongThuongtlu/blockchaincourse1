using System;
using System.Text;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;
using BlockChainCourse.Cryptography;

namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public class Transaction : ITransaction
    {
        public string ToChucCap { get; set; }
        public string NguoiNhanChungChi { get; set; }
        public string SoCMT { get; set; }
        public string NgayCap { get; set; }
        public string ThoiHan { get; set; }
        public ClaimType ClaimType { get; set; }
        public override string ToString()
        {
            return string.Format("{0}S{1}S{2}S{3}S{4}",ToChucCap,NguoiNhanChungChi,SoCMT,NgayCap,ThoiHan);
        }
        public Transaction(string a,string b, string c, string d, string t, ClaimType f)
        {
            ToChucCap = a;
            NguoiNhanChungChi = b;
            SoCMT = c;
            NgayCap = d;
            ThoiHan = t;
            ClaimType = f;
        }
        public Transaction(string readFromFile)
        {
            string[] arr = readFromFile.Split(new char[] { (char)ConsoleKey.S }, StringSplitOptions.RemoveEmptyEntries);
            this.ToChucCap = arr[0];
            this.NguoiNhanChungChi = arr[1];
            this.SoCMT = arr[2];
            this.NgayCap = arr[3];
            this.ThoiHan = arr[4];
            this.ClaimType = ClaimType.TotalLoss;
        }

        public string CalculateTransactionHash()
        {
            string txnHash = ToChucCap+NguoiNhanChungChi+SoCMT+NgayCap+ThoiHan+ClaimType;
            return Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(txnHash)));
        }
    }
}