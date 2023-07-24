namespace JaxWorld.Data.Entities.Blockchain.Configurations.Standard
{
    using JaxWorld.Data.Entities.Blockchain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Tokens;

    public class StandardConfig : IEntityTypeConfiguration<Standard>
    {
        public void Configure(EntityTypeBuilder<Standard> builder)
        {
            builder.HasData(
                    new Standard
                    {
                        Id = 1,
                        Name = "ERC721"
                    });
            builder.HasData(
                    new Standard
                    {
                        Id = 2,
                        Name = "ERC721a"
                    });

            builder.HasData(
                    new Standard
                    {
                        Id = 3,
                        Name = "ERC20"
                    });

            builder.HasData(
                    new Standard
                    {
                        Id = 4,
                        Name = "ERC1155"
                    });
        }
    }
}

