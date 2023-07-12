namespace JaxWorld.Data.Blockchain.Contracts
{
    using Transactions;
    using Interfaces.IBlockchain.IContracts;

    public class Contract : IContract
    {
        public Contract()
        {
            Transactions = new HashSet<Transaction>();
            InternalTxns = new HashSet<Transaction>();
            ERC20TokenTxns = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ContractInfo ContractData { get; set; }
        public virtual ContractOverview ContractOverviewData { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Transaction> InternalTxns { get; set; }
        public virtual ICollection<Transaction> ERC20TokenTxns { get; set; }
    }
}
