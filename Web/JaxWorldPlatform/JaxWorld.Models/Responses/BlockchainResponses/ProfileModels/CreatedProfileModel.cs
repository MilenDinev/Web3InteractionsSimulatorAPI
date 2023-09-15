namespace JaxWorld.Models.Responses.BlockchainResponses.ProfileModels
{
    using Interfaces;

    public class CreatedProfileModel : ICreated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NetworkId { get; set; }
        public int CreatorId { get; set; }
        public int CreatorWalletId { get; set; }
    }
}
