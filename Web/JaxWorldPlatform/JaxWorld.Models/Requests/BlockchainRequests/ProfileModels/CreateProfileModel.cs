namespace JaxWorld.Models.Requests.BlockchainRequests.ProfileModels
{
    using Constants;
    using System.ComponentModel.DataAnnotations;

    public class CreateProfileModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(20, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(6, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 2)]
        public string Symbol { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(100, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 10)]
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int StandardId { get; set; }
        public int ContractId { get; set; }
    }
}

