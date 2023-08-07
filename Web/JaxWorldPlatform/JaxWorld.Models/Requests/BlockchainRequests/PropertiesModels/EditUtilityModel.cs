namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class EditUtilityModel : EditPropertyModel
    {
        [MinLength(2, ErrorMessage = "DisplayType must be between 2 and 10 symbols!")]
        [MaxLength(10, ErrorMessage = "DisplayType must be between 2 and 10 symbols!")]
        public string DisplayType { get; set; }
        public decimal Value { get; set; }
    }
}