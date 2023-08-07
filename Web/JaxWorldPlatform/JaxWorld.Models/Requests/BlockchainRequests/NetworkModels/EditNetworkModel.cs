namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditNetworkModel
    {
        [MinLength(2, ErrorMessage = "Name must be between 2 and 25 symbols!")]
        [MaxLength(25, ErrorMessage = "Name must be between 2 and 25 symbols!")]
        public string Name { get; init; }

        [MinLength(1, ErrorMessage = "Symbol must be between 1 and 10 symbols!")]
        [MaxLength(10, ErrorMessage = "Symbol must be between 1 and 10 symbols!")]
        public string Symbol { get; init; }
        public int? ChainId { get; init; }

        [MinLength(5, ErrorMessage = "RpcUrl must be between 5 and 35 symbols!")]
        [MaxLength(35, ErrorMessage = "RpcUrl must be between 5 and 35 symbols!")]
        public string RpcUrl { get; init; }

        [MinLength(5, ErrorMessage = "ExplorerUrl must be between 5 and 35 symbols!")]
        [MaxLength(35, ErrorMessage = "ExplorerUrl must be between 5 and 35 symbols!")]
        public string? ExplorerUrl { get; init; }
    }
}
