namespace JaxWorld.Data.Entities.Transactions
{
    using Microsoft.EntityFrameworkCore;
    using Constants;

    public class Block : Entity
    {
        public Block()
        {
            this.Transactions = new HashSet<Transaction>();
        }

        public ulong BlockHeight { get; set; }
        public DateTime Timestamp { get; set; }
        public long GasUsed { get; set; }
        public long GasLimit { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal BaseFeePerGas { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Price { get; set; }
        public string Hash { get; set; }
        public string ParentHash { get; set; }
        public string Sha3Uncles { get; set; }
        public string Nonce { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
