namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    public class CreateTransactionModel
    {
        public string TxnHash { get; set; }
        public int StateId { get; set; }
        public int TargetId { get; set; }
        public int InitiatorId { get; set; }
        public int NetworkId { get; set; }
        public int BlockId { get; set; }
        public int TxnActionId { get; set; }
    }
}
