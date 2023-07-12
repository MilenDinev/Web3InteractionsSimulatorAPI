namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.IWallets
{
    using Blockchain.Transactions;
    using JaxWorld.Data.Entities.Blockchain.Transactions;

    public interface IWallet
    {
        string Address { get; set; }
        decimal Balance { get; set; }
        int OwnerId { get; set; }
        int ProviderId { get; set; }

        ICollection<Transaction> Transactions { get; set; }
    }
}
