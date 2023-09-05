namespace JaxWorld.Models.Requests.BlockchainRequests.BlockModels
{
    public class CreateBlockModel
    {
        public int NetworkId { get; set; }
        public long GasUsed { get; set; }
        public long GasLimit { get; set; }
        public decimal BaseFeePerGas { get; set; }
        public decimal Price { get; set; }
        public string? TxnHash { get; set; }
        public string? Hash { get; set; }
    }
}
