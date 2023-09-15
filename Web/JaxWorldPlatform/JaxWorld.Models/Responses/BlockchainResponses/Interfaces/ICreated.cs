namespace JaxWorld.Models.Responses.BlockchainResponses.Interfaces
{
    public interface ICreated
    {
        public int Id { get; set; }
        public int NetworkId { get; set; }
        public int CreatorId { get; set; }
        public int CreatorWalletId { get; set; }
    }
}
