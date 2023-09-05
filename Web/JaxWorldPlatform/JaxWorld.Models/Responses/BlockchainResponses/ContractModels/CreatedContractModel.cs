namespace JaxWorld.Models.Responses.BlockchainResponses.ContractModels
{
    public class CreatedContractModel
    {
        public int Id { get; set; }
        public int NetworkId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public int CreatorWalletId { get; set; }
        public string CreatorWallet { get; set; }
        public string OwnerWallet { get; set; }
    }
}
