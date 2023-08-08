namespace JaxWorld.Models.Requests.EntityRequests
{
    using System.ComponentModel.DataAnnotations;

    public class EditUserModel
    {
        public string? UserName { get; set; }
        public string? WalletAddress { get; set; }
        [EmailAddress(ErrorMessage = "Please provide valid email address!")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
