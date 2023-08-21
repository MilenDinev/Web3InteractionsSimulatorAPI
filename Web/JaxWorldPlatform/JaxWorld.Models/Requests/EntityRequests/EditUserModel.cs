namespace JaxWorld.Models.Requests.EntityRequests
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditUserModel
    {
        [StringLength(25, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 4)]
        public string? UserName { get; set; }

        [StringLength(50, ErrorMessage = ValidationMessages.MinMaxLength, MinimumLength = 5)]
        public string? WalletAddress { get; set; }

        [EmailAddress(ErrorMessage = ValidationMessages.Email)]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}

