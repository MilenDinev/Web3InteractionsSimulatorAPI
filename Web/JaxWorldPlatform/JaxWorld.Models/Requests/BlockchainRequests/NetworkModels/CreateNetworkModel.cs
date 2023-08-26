namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateNetworkModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.NetworkNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.NetworkNameMinLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(AttributesParams.NetworkSymbolMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.NetworkSymbolMinLength)]
        public string Symbol { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [Url(ErrorMessage = ValidationMessages.URL)]
        public string RpcUrl { get; set; }
        public int ChainId { get; set; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? ExplorerUrl { get; set; }
    }
}
