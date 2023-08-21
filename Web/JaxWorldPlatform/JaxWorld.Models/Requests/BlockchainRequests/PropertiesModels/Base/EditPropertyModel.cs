namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using System.ComponentModel.DataAnnotations;
    using Constants;
    using Interfaces;

    public abstract class EditPropertyModel : IEditPropertyModel
    {
        [StringLength(15, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string? TraitType { get; set; }
    }
}
