namespace JaxWorld.Models.Responses.BlockchainResponses.ProfileUnitModels
{
    public class CreatedErc721aUnitModel
    {
        public int Id { get; set; }
        public int MinterId { get; set; }
        public string MinterAddress { get; set; }
        public string Name { get; set; }
        public string DNA { get; set; }
        public string? imgUrl { get; set; }
        public int ContractId { get; set; }
        public int NetworkId { get; set; }
    }
}
