namespace JaxWorld.Models.Responses.BlockchainResponses.ProfileUnitModels
{
    using Interfaces;

    public class CreatedErc721aUnitModel : ICreated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NetworkId { get; set; }
        public int CreatorId { get; set; }
        public int CreatorWalletId { get; set; }
    }
}
