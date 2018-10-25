using System;
using System.Collections.Generic;

namespace BlockChainCourse.BlockWithMultipleTransactions.Interfaces
{
    public interface IBlock
    {
        // List of transactions
        List<ITransaction> Transaction { get; }

        // Block header data
        int BlockNumber { get; }
        DateTime CreatedDate { get; set; }
        string BlockHash { get; }
        string PreviousBlockHash { get; set; }
        void Add(int a,
                            DateTime b,
                            string c,
                            string d, IBlock parent);
        void BuildMerkleTree();
        void AddTransaction(ITransaction transaction);
        string CalculateBlockHash(string previousBlockHash);
        void SetBlockHash(IBlock parent);
        IBlock NextBlock { get; set; }
        bool IsValidChain(string prevBlockHash, bool verbose);
        string GetMerkleTree();
    }
}