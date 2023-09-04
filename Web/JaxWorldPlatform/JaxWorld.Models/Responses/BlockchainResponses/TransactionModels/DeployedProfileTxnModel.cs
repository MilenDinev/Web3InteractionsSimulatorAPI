namespace JaxWorld.Models.Responses.BlockchainResponses.TransactionModels
{
    public class DeployedProfileTxnModel
    {
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string Standard { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public string ContractAddress { get; set; }
    }
}
