namespace JaxWorld.Models.Requests.EntityRequests
{
    public class EditUserModel
    {
        public string Username { get; set; }
        public string NormalizedName { get; set; }
        public string WalletAddress { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool Deleted { get; set; }
    }
}
