namespace JaxWorld.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Entities;
    using Entities.Blockchain;
    using Entities.Blockchain.Tokens;
    using Entities.Blockchain.Wallets;
    using Entities.Blockchain.Contracts;
    using Entities.Blockchain.Properties;
    using Entities.Blockchain.Transactions;
    using Entities.Blockchain.Tokens.Erc721.Units;
    using Entities.Blockchain.Tokens.Erc721.Profiles;

    public class JaxWorldDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
        public JaxWorldDbContext(DbContextOptions<JaxWorldDbContext> options) : base(options)
        { }

        public virtual DbSet<Network> Networks { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Erc721aProfile> Erc721aProfiles { get; set; }
        public virtual DbSet<Erc721aUnit> Erc721aUnits { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<Utility> Utilities { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
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