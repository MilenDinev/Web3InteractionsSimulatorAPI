namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class CreateAttributeModel : CreatePropertyModel
    {
        [Required(ErrorMessage = "Property value is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Property value is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Property value is required and must be between 2 and 15 symbols!")]
        public string Value { get; set; }
    }
}
