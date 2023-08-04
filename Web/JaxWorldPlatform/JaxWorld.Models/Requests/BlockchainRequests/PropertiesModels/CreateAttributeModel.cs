namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class CreateAttributeModel : CreatePropertyModel
    {
        [Required]
        public string Value { get; set; }
    }
}
