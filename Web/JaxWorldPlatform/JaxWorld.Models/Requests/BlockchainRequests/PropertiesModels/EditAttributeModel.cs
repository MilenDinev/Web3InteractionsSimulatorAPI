namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class EditAttributeModel : EditPropertyModel
    {
        [MinLength(2, ErrorMessage = "Value must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Value must be between 2 and 15 symbols!")]
        public string Value { get; set; }
    }
}
