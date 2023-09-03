namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    public class CreateTransactionModel
    {
        public int CreatorId { get; set; }
        public int NetworkId { get; set; }
        public string TxnHash { get; set; }
        public int InitiatorWalletId { get; set; }
        public int StateId { get; set; }
        public int BlockId { get; set; }
        //public int TxnActionId { get; set; }
    }
}
