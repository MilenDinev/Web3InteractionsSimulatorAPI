namespace JaxWorld.Services.AutoMapperProfiles.Network
{
    using AutoMapper;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;

    internal class NetworkMappingProfile : Profile
    {
        internal NetworkMappingProfile()
        {
            this.CreateMap<CreateNetworkModel, Network>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Network, CreatedNetworkModel>();
            this.CreateMap<Network, EditedNetworkModel>();
            this.CreateMap<Network, DeletedNetworkModel>();
            this.CreateMap<Network, NetworkListingModel>();
        }
    }
}
