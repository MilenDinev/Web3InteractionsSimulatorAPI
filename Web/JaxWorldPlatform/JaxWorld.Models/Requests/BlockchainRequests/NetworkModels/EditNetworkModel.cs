namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditNetworkModel
    {
        [StringLength(AttributesParams.NetworkNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.NetworkNameMinLength)]
        public string? Name { get; init; }

        [StringLength(AttributesParams.NetworkSymbolMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.NetworkSymbolMinLength)]
        public string? Symbol { get; init; }

        [Range(1, int.MaxValue)]
        public int? ChainId { get; init; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? RpcUrl { get; init; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? ExplorerUrl { get; init; }
    }
}
