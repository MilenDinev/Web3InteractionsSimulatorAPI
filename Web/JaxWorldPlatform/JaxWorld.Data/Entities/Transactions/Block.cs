namespace JaxWorld.Data.Entities.Transactions
{
    using Microsoft.EntityFrameworkCore;

    public class Block : Entity
    {
        public Block()
        {
            this.Transactions = new HashSet<Transaction>();
        }

        public ulong BlockHeight { get; set; }
        public DateTime Timestamp { get; set; }
        [Precision(18, 2)]
        public decimal BurnedFees { get; set; }
        public int UnclesReward { get; set; }
        public int Difficulty { get; set; }
        public ulong TotalDifficulty { get; set; }
        public ulong Size { get; set; }
        public ulong GasUsed { get; set; }
        public ulong GasLimit { get; set; }
        [Precision(18, 2)]
        public decimal BaseFeePerGas { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public string Hash { get; set; }
        public string ParentHash { get; set; }
        public string Sha3Uncles { get; set; }
        public string Nonce { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
