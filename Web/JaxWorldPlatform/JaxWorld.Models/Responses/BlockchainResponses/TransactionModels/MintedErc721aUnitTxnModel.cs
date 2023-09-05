namespace JaxWorld.Models.Responses.BlockchainResponses.TransactionModels
{
    public class MintedErc721aUnitTxnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractAddress { get; set; }
        public string MinterAddress { get; set; }
        public string TxnHash { get; set; }
    }
}
