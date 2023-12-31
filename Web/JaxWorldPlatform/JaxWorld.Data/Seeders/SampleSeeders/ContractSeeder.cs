﻿namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities;
    using Constants;

    internal static class ContractSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {
            var deployerWallet = await context.Wallets.FindAsync(1);

            var deployerContract = new Contract
            {
                Name = "Deployer",
                Address = "0x000000000000000000",
                NormalizedTag = "0x000000000000000000".ToUpper(),
                Balance = 0.00m,
                CreatorId = CreatorParams.Id,
                CreationDate = DateTime.Now,
                LastModifierId = CreatorParams.Id,
                LastModificationDate = DateTime.Now,
                NetworkId = 1,
                CreatorWalletId = 1,                          
            };

            deployerContract.ApprovedBy.Add(deployerWallet);

            await context.Contracts.AddAsync(deployerContract);
            await context.SaveChangesAsync();
        }
    }
}
