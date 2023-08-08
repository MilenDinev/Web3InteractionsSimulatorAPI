namespace JaxWorld.Models.Requests.BlockchainRequests.NetworkModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateNetworkModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(25, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(6, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? Symbol { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? RpcUrl { get; set; }
        public int ChainId { get; set; }

        [Url(ErrorMessage = ValidationMessages.URL)]
        public string? ExplorerUrl { get; set; }
    }
}
