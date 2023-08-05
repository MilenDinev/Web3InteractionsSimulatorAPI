namespace JaxWorld.Data.Configurations.Profile
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Profiles;
    using Entities.Blockchain.Contracts;

    public class ProfileContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.Profile)
            .WithOne(u => u.Contract)
            .HasForeignKey<Profile>(e => e.ContractId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}