namespace JaxWorld.Data.Entities.Wallets
{
    using Microsoft.EntityFrameworkCore;
    using Units;
    using Entities;
    using Contracts;
    using Transactions;
    using Interfaces.IEntities.IWallets;

    public class Wallet : Entity, IWallet
    {
        public Wallet()
        {
            Networks = new HashSet<Network>();
            Transactions = new HashSet<Transaction>();
            CreatedContracts = new HashSet<Contract>();
            Erc721aUnits = new HashSet<Erc721aUnit>();
        }

        public string Address { get; set; }
        [Precision(18, 2)]
        public decimal Balance { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Network> Networks { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> CreatedContracts { get; set; }
        public virtual ICollection<Erc721aUnit> Erc721aUnits { get; set; }
    }
}
