namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class EditAttributeModel : EditPropertyModel
    {
        [StringLength(AttributesParams.ValueMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.ValueMinLength)]
        public string? Value { get; set; }
    }
}
