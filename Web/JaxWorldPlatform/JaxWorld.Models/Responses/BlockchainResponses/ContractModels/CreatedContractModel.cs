namespace JaxWorld.Models.Responses.BlockchainResponses.ContractModels
{
    using Interfaces;

    public class CreatedContractModel : ICreated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NetworkId { get; set; }
        public int CreatorId { get; set; }
        public int CreatorWalletId { get; set; }
    }
}
