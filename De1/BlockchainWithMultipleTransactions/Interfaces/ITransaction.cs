using System;

namespace BlockChainCourse.BlockWithMultipleTransactions.Interfaces
{
    public interface ITransaction
    {

        string MNV { get; set; }
        string MaSach { get; set; }
        DateTime TGMuon { get; set; }
        string NguoiMuon { get; set; }
        double ChiPhi { get; set; }
        DateTime TGTra { get; set; }
        ClaimType ClaimType { get; set; }
        string CalculateTransactionHash();
    }
}