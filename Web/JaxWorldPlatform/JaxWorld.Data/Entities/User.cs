﻿namespace JaxWorld.Data.Entities
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using Wallets;
    using Interfaces.IEntities;

    public class User : IdentityUser<int>, IEntity
    {
        public int CreatorId { get; set; }
        public virtual User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastModifierId { get; set; }
        public virtual User LastModifier { get; set; }
        public DateTime LastModificationDate { get; set; }
        public string NormalizedTag { get; set; }
        public bool Deleted { get; set; }
        public int WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}
