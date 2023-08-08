namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditNetworkModel
    {
        [StringLength(25, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; init; }

        [StringLength(10, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 1)]
        public string? Symbol { get; init; }
        public int? ChainId { get; init; }

        [StringLength(35, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? RpcUrl { get; init; }

        [StringLength(35, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? ExplorerUrl { get; init; }
    }
}
