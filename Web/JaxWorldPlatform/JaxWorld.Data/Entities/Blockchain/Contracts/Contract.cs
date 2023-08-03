namespace JaxWorld.Data.Entities.Blockchain.Contracts
{
    using Base;
    using Wallets;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.IContracts;

    public class Contract : Entity, IContract
    {
        public Contract()
        {

            Networks = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Balance { get; set; }
        public string EstimatedValue { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public int CreatedTxnId { get; set; }
        public virtual Wallet Creator { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
