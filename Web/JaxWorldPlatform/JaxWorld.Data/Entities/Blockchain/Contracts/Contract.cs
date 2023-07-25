namespace JaxWorld.Data.Entities.Blockchain.Contracts
{
    using Wallets;
    using Transactions;
    using Profiles.Base;
    using Interfaces.IEntities.IBlockchain.IContracts;
    using JaxWorld.Data.Interfaces.IEntities.IBlockchain.IContracts;

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
        public virtual ContractProfile Profile { get; set; }
        public int CreatedTxnId { get; set; }
        public virtual Transaction CreatedTxn { get; set; }
        public virtual Wallet Creator { get; set; }
        public int NetworkId { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
