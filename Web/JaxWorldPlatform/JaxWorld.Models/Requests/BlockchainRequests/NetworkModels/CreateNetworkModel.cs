namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateNetworkModel
    {
        [Required(ErrorMessage = "Network name is required and must be between 2 and 25 symbols!")]
        [MaxLength(25, ErrorMessage = "Network name is required and must be between 2 and 25 symbols!")]
        [MinLength(2, ErrorMessage = "Network name is required and must be between 2 and 25 symbols!")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Network symbol is required and must be between 1 and 10 symbols!")]
        [MaxLength(10, ErrorMessage = "Network symbol is required and must be between 1 and 10 symbols!")]
        [MinLength(1, ErrorMessage = "Network symbol is required and must be between 1 and 10 symbols!")]
        public string Symbol { get; init; }

        [Required(ErrorMessage = "Network rpcUrl is required and must be between 5 and 35 symbols!")]
        [MaxLength(35, ErrorMessage = "Network symbol is required and must be between 5 and 35 symbols!")]
        [MinLength(5, ErrorMessage = "Network symbol is required and must be between 5 and 35 symbols!")]
        public string RpcUrl { get; init; }
        public int ChainId { get; init; }
        public string? ExplorerUrl { get; init; }
    }
}
