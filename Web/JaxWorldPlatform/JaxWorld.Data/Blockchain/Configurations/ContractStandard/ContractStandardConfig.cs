namespace JaxWorld.Data.Blockchain.Configurations.ContractStandard
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Contracts;

    public class ContractStandardConfig : IEntityTypeConfiguration<ContractStandard>
    {
        public void Configure(EntityTypeBuilder<ContractStandard> builder)
        {
            builder.HasData(
                    new ContractStandard
                    {
                        Id = 1,
                        Name = "ERC721"
                    });
            builder.HasData(
                    new ContractStandard
                    {
                        Id = 2,
                        Name = "ERC721a"
                    });

            builder.HasData(
                    new ContractStandard
                    {
                        Id = 3,
                        Name = "ERC20"
                    });

            builder.HasData(
                    new ContractStandard
                    {
                        Id = 4,
                        Name = "ERC1155"
                    });
        }
    }
}

