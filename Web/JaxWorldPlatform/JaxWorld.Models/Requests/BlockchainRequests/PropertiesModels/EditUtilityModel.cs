namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using JaxWorld.Models.Constants;
    using System.ComponentModel.DataAnnotations;

    public class EditUtilityModel : EditPropertyModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 3)]
        public string? DisplayType { get; set; }
        public decimal? Value { get; set; }
    }
}