namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateTransactionModel
    {
        [Range(1, int.MaxValue)]
        public int CreatorId { get; set; }

        [Range(1, int.MaxValue)]
        public int NetworkId { get; set; }
        public string? TxnHash { get; set; }

        [Range(1, int.MaxValue)]
        public int TargetId { get; set; }

        [Range(1, int.MaxValue)]
        public int InitiatorWalletId { get; set; }

        [Range(1, int.MaxValue)]
        public int BlockId { get; set; }

        [Range(1, int.MaxValue)]
        public int StateId { get; set; }

        [Range(1, int.MaxValue)]
        public int TxnActionId { get; set; }
    }
}
