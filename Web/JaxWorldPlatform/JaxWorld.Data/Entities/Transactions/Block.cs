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
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
