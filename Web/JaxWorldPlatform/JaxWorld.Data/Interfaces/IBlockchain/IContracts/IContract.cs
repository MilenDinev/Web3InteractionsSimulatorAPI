namespace JaxWorld.Data.Interfaces.IBlockchain.IContracts
{
    public interface IContract
    {
        string Name { get; set; }
        int StandardId { get; set; }
        int CreatedTxnId { get; set; }
        int CreatorId { get; set; }
        int LastModifierId { get; set; }
        int OwnerId { get; set; }
        int ChainId { get; set; }
    }
}
