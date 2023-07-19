namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.IWallets
{

    public interface IWallet
    {
        string Address { get; set; }
        decimal Balance { get; set; }
        int OwnerId { get; set; }
        int ProviderId { get; set; }
    }
}
