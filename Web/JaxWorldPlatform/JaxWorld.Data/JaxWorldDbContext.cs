namespace JaxWorld.Data
{
    using Entities;
    using Entities.Contracts;
    using Entities.Profiles;
    using Entities.Properties;
    using Entities.Transactions;
    using Entities.Units;
    using Entities.Wallets;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class JaxWorldDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public JaxWorldDbContext(DbContextOptions<JaxWorldDbContext> options) : base(options)
        { }

        public virtual DbSet<Network> Networks { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TxnAction> TxnActions { get; set; }
        public virtual DbSet<TransactionState> TransactionStates { get; set; }
        public virtual DbSet<TxnLog> TransactionLogs { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Erc721aUnit> Erc721aUnits { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<Utility> Utilities { get; set; }
        public virtual DbSet<Provider> WalletProviders { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assemblyWithConfigurations = GetType().Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
            base.OnModelCreating(modelBuilder);
        }
    }
}