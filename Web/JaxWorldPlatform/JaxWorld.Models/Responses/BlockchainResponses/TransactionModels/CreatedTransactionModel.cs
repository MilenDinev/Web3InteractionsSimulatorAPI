namespace JaxWorld.Models.Responses.BlockchainResponses.TransactionModels
{
    public class CreatedTransactionModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string TxnHash { get; set; }
        public string State { get; set; }
    }
}
