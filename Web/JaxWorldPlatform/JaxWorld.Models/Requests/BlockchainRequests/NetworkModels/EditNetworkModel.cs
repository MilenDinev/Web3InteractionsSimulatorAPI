namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

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
        public int? ChainId { get; init; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? RpcUrl { get; init; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? ExplorerUrl { get; init; }
    }
}
