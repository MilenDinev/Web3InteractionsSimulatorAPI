namespace JaxWorld.Services.AutoMapperProfiles.Network
{
    using AutoMapper;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    internal class NetworkMappingProfile : Profile
    {
        public NetworkMappingProfile()
        {
            this.CreateMap<CreateContractModel, Network>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Network, CreatedContractModel>();
            this.CreateMap<Network, EditedContractModel>();
        }
    }
}
