namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using JaxWorld.Models.Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditUtilityModel : EditPropertyModel
    {
        [StringLength(AttributesParams.DisplayTypeMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.DisplayTypeMinLength)]
        public string? DisplayType { get; set; }
        public decimal? Value { get; set; }
    }
}