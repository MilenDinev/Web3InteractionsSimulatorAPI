namespace JaxWorld.Models.Requests.EntityRequests
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class CreateUserModel
    {
        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(25, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 4)]
        public string? UserName { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [StringLength(50, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? WalletAddress { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        [EmailAddress(ErrorMessage = ValidationMessages.Email)]
        public string? Email { get; set; }

        [Required(ErrorMessage = ValidationMessages.Required)]
        public string? Password { get; set; }
    }
}