namespace JaxWorld.Models.Requests.EntityRequests
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class EditUserModel
    {
        [StringLength(AttributesParams.UserNameMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.UserNameMinLength)]
        public string? UserName { get; set; }

        [StringLength(AttributesParams.WalletAddressMaxLength,
            ErrorMessage = ValidationMessages.MinMaxLength,
            MinimumLength = AttributesParams.WalletAddressMinLength)]
        public string? WalletAddress { get; set; }

        [EmailAddress(ErrorMessage = ValidationMessages.Email)]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}

