using System;
using System.Text;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;
using BlockChainCourse.Cryptography;

namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public class Transaction : ITransaction
    {
        public string MSV { get; set; }
        public string MaMon { get; set; }
        public DateTime TGNhapDiem { get; set; }
        public double Diem { get; set; }
        public int DiemLanThu { get; set; }
        public ClaimType ClaimType { get; set; }
        public override string ToString()
        {
            return string.Format("{0}S{1}S{2}S{3}S{4}",MSV,MaMon,TGNhapDiem,Diem,DiemLanThu);
        }
        public Transaction(string a,string b, DateTime c, double d, int e, ClaimType f)
        {
            MSV = a;
            MaMon = b;
            TGNhapDiem = c;
            Diem = d;
            DiemLanThu = e;
            ClaimType = f;
        }
        public Transaction(string readFromFile)
        {
            string[] arr = readFromFile.Split(new char[] { (char)ConsoleKey.S }, StringSplitOptions.RemoveEmptyEntries);
            this.MSV = arr[0];
            this.MaMon = arr[1];
            this.TGNhapDiem = Convert.ToDateTime(arr[2]);
            this.Diem = Convert.ToInt32(arr[3]);
            this.DiemLanThu = Convert.ToInt32(arr[4]);
        }

        public string CalculateTransactionHash()
        {
            string txnHash = MSV+MaMon+TGNhapDiem+Diem+DiemLanThu+ClaimType;
            return Convert.ToBase64String(HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(txnHash)));
        }
    }
}