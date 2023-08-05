namespace JaxWorld.Services.AutoMapperProfiles.Network
{
    using AutoMapper;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;

    public class NetworkMappingProfile : Profile
    {
        public NetworkMappingProfile()
        {
            this.CreateMap<CreateNetworkModel, Network>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()))
                .ForMember(e => e.ChainId, m=> m.MapFrom(m => m.ChainId.ToString()));
            this.CreateMap<Network, CreatedNetworkModel>();
            this.CreateMap<Network, EditedNetworkModel>();
            this.CreateMap<Network, DeletedNetworkModel>();
            this.CreateMap<Network, NetworkListingModel>();
        }
    }
}
