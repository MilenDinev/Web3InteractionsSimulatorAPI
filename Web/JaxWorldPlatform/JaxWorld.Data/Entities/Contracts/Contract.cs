﻿namespace JaxWorld.Data.Entities.Contracts
{
    using Microsoft.EntityFrameworkCore;
    using Wallets;
    using Profiles;
    using Transactions;
    using Interfaces.IEntities.IContracts;

    public class Contract : Entity, IContract
    {
        public Contract()
        {

            Networks = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        [Precision(18, 2)]
        public decimal Balance { get; set; }
        [Precision(18, 2)]
        public decimal EstimatedValue { get; set; }
        public int CreationTxnId { get; set; }
        public virtual Transaction CreationTxn { get; set; }
        public int CreatorWalletId { get; set; }
        public virtual Wallet CreatorWallet { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
