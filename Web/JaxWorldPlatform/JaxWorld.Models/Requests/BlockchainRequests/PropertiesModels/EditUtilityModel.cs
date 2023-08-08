namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class EditUtilityModel : EditPropertyModel
    {
        [MinLength(2, ErrorMessage = "DisplayType must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "DisplayType must be between 2 and 15 symbols!")]
        public string? DisplayType { get; set; }
        public decimal? Value { get; set; }
    }
}