using System;

namespace BlockChainCourse.BlockWithMultipleTransactions.Interfaces
{
    public interface ITransaction
    {

        string MSV { get; set; }
        string MaMon { get; set; }
        DateTime TGNhapDiem { get; set; }
        double Diem { get; set; }
        int DiemLanThu { get; set; }
        ClaimType ClaimType { get; set; }
        string CalculateTransactionHash();
    }
}