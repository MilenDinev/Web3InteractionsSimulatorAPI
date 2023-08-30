 namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    public class DeployContractTransactionModel
    {
        public string TxnHash { get; set; }
        public int ContractId { get; set; }
        public string CreatorAddress { get; set; }
        public string OwnerAddress { get; set; }
    }
}
