namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Constants;

    public class EditAttributeModel : EditPropertyModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 3)]
        public string? Value { get; set; }
    }
}
