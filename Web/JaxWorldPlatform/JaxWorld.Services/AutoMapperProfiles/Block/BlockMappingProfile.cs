namespace JaxWorld.Services.AutoMapperProfiles.Block
{
    using AutoMapper;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.BlockModels;
    using Models.Responses.BlockchainResponses.BlockModels;

    public class BlockMappingProfile : Profile
    {
        public BlockMappingProfile()
        {
            this.CreateMap<CreateBlockModel, Block>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Hash.ToUpper()))
                .ForMember(e => e.GasLimit, m => m.MapFrom(m => 15000000));
            this.CreateMap<Block, CreatedBlockModel>();
            this.CreateMap<Block, EditedBlockModel>();
            this.CreateMap<Block, BlockListingModel>();
        }
    }
}