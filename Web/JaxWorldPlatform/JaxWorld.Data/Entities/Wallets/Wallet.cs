﻿namespace JaxWorld.Data.Entities.Wallets
{
    using Microsoft.EntityFrameworkCore;
    using Base;
    using Units;
    using Entities;
    using Constants;
    using Transactions;
    using JaxWorld.Data.Entities.Whitelists;

    public class Wallet : Entity
    {
        public Wallet()
        {
            Networks = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
            CreatedContracts = new HashSet<Contract>();
            ApprovedContracts = new HashSet<Contract>();
            Erc721aUnits = new HashSet<Erc721aUnit>();
            this.Whitelists = new HashSet<Whitelist>();
        }

        public string Address { get; set; }
        public bool IsActive { get; set; }

        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Balance { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> ApprovedContracts { get; set; }
        public virtual ICollection<Contract> CreatedContracts { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721aUnits { get; set; }
        public virtual ICollection<Whitelist> Whitelists { get; set; }
    }
}
