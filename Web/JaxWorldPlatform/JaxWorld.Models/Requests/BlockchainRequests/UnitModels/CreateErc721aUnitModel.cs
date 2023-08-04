namespace JaxWorld.Models.Requests.BlockchainRequests.UnitModels
{
    public class CreateErc721aUnitModel
    {
        public string Name { get; set; }
        public int ContractProfileId { get; set; }
        public int MintedTxnId { get; set; }
        public string DNA { get; set; }
    }
}
