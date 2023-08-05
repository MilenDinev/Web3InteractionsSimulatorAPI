namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;
    using System.ComponentModel.DataAnnotations;

    public abstract class CreatePropertyModel : ICreatePropertyModel
    {
        [Required(ErrorMessage = "Property name is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Property name is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Property name is required and must be between 2 and 15 symbols!")]
        public string Name { get; set; }
    }
}
