
namespace JaxWorld.Data.Entities.Blockchain.Configurations.Contract
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Blockchain.Profiles;
    using JaxWorld.Data.Entities.Blockchain.Base;

    public class ContractProfileConfig : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasOne(s => s.Contract)
                .WithOne(u => u.Profile);
        }
    }
}
