namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileUnitModels
{
    public class CreateProfileUnitModel
    {
        public string Name { get; set; }
        public int ContractProfileId { get; set; }
        public int MintedTxnId { get; set; }
        public string DNA { get; set; }
    }
}
