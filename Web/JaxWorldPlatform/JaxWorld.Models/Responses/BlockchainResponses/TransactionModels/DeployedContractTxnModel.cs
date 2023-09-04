namespace JaxWorld.Models.Responses.BlockchainResponses.TransactionModels
{
    public class DeployedContractTxnModel
    {
        public int BlockId { get; set; }
        public string TxnHash { get; set; }
        public string TxnState { get; set; }
        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public string ContractAddress { get; set; }
        public string CreatorAddress { get; set; }
        public string OwnerAddress { get; set; }
    }
}
