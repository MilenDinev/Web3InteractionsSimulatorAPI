namespace JaxWorld.Models.Requests.EntityRequests
{
    using System.ComponentModel.DataAnnotations;

    public class CreateUserModel
    {
        [Required(ErrorMessage = "Username is required!")]
        public string UserName { get; set; }
        public string? WalletAddress { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Please provide valid email address!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
    }
}


