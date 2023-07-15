namespace JaxWorld.Data.Entities
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using Blockchain.Wallets;
    using Interfaces.IEntities;
    using Blockchain.Transactions;

    public class User : IdentityUser<int>, IEntity
    {
        public User()
        {
            this.Wallets = new HashSet<Wallet>();
        }
        public string Username { get; set; }
        public string NormalizedName { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Wallet> Wallets { get; set; }
        
    }
}
