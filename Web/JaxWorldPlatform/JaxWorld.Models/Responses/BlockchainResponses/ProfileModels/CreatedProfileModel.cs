namespace JaxWorld.Models.Responses.BlockchainResponses.ProfileModels
{
    public class CreatedProfileModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int StandardId { get; set; }
        public int NetworkId { get; set; }
        public int CreatorWalletId { get; set; }
    }
}
