namespace JaxWorld.Services.Main
{
    using System.Globalization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper;
    using Base;
    using Main.Interfaces;
    using Data;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.BlockModels;

    public class BlockService : BaseService<Block>, IBlockService
    {
        private readonly IMapper mapper;

        public BlockService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Block> CreateAsync(CreateBlockModel blockModel, int creatorId)
        {
            blockModel.Hash = await CreateBlockHashAsync(blockModel.TxnHash);

            var block = mapper.Map<Block>(blockModel);

            await CreateEntityAsync(block, creatorId);

            return block;
        }

        public async Task<Block> GetCurrentBlockAsync(long gasUsed)
        {
            var currentBlock = await this.dbContext.Blocks.FirstOrDefaultAsync(x => x.Transactions.Count < 10 && x.GasUsed <= 15000000 - gasUsed);
            return currentBlock;
        }


        internal async Task<string> CreateBlockHashAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var blockHash = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(blockHash.ToString);
        }
    }
}
