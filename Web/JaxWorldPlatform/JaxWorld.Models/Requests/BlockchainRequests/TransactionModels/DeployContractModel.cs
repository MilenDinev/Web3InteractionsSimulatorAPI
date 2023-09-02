 namespace JaxWorld.Models.Requests.BlockchainRequests.TransactionModels
{
    public class DeployContractModel
    {
        public int NetworkId { get; set; }
        public string TargetContract { get; set; }
        public string InitiatorWallet { get; set; }
    }
}
