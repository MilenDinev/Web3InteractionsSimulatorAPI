namespace JaxWorld.Data.Interfaces.IEntities.ITransactions
{
    public interface ITransaction
    {
        string TxnHash { get; set; }
        DateTime CreationDate { get; set; }
        int StateId { get; set; }
        int? ContractId { get; set; }
        int NetworkId { get; set; }
    }
}
