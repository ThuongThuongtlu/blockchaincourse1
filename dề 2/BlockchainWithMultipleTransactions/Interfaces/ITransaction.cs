using System;

namespace BlockChainCourse.BlockWithMultipleTransactions.Interfaces
{
    public interface ITransaction
    {

        string ToChucCap { get; set; }
        string NguoiNhanChungChi { get; set; }
        string SoCMT { get; set; }
        string NgayCap { get; set; }
        string ThoiHan { get; set; }
        ClaimType ClaimType { get; set; }
        string CalculateTransactionHash();
    }
}