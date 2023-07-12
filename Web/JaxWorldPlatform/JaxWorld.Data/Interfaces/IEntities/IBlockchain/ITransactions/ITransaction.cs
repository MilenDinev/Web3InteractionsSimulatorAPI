namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.ITransactions
{
    public interface ITransaction
    {
        string TxnHash { get; set; }
        DateTime CreatedOn { get; set; }
        int StateId { get; set; }
        int CreatorId { get; set; }
        int ContractId { get; set; }
        int ChainId { get; set; }

    }
}
