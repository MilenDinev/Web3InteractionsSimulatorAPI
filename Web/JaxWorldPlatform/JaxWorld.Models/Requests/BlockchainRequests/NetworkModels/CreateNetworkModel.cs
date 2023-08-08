namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateNetworkModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage = "Name must be between 2 and 25 symbols!")]
        [MaxLength(25, ErrorMessage = "Name must be between 2 and 25 symbols!")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Symbol is required!")]
        [MinLength(1, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        [MaxLength(5, ErrorMessage = "Symbol must be between 1 and 5 symbols!")]
        public string Symbol { get; init; }

        [Required(ErrorMessage = "RpcUrl is required!")]
        [MinLength(5, ErrorMessage = "RpcUrl must be between 5 and 55 symbols!")]
        [MaxLength(55, ErrorMessage = "RpcUrl must be between 5 and 55 symbols!")]
        public string RpcUrl { get; init; }
        public int ChainId { get; init; }

        [MinLength(5, ErrorMessage = "ExplorerUrl must be between 5 and 55 symbols!")]
        [MaxLength(55, ErrorMessage = "ExplorerUrl must be between 5 and 55 symbols!")]
        public string? ExplorerUrl { get; init; }
    }
}
