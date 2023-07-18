namespace JaxWorld.Data.Entities.Blockchain.Contracts
{
    using Wallets;
    using Tokens.Base;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.IContracts;

    public class Contract : IContract
    {
        public Contract()
        {

            Networks = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Balance { get; set; }
        public string EstimatedValue { get; set; }
        public int ProfileId { get; set; }
        public virtual ContractProfile Profile { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedTxnId { get; set; }
        public virtual Transaction CreatedTxn { get; set; }
        public int CreatorId { get; set; }
        public virtual Wallet Creator { get; set; }
        public int NetworkId { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
