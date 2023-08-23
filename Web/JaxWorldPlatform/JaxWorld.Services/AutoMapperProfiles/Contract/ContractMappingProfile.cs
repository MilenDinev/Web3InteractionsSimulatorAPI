namespace JaxWorld.Services.AutoMapperProfiles.Contract
{
    using AutoMapper;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractMappingProfile : Profile
    {
        public ContractMappingProfile()
        {
            this.CreateMap<CreateContractModel, Contract>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()))
                .ForMember(e => e.Address, m => m.MapFrom(m => m.ContractAddress))
                .ForMember(e => e.CreatorWalletId, m => m.MapFrom(m => 1));
            this.CreateMap<Contract, CreatedContractModel>();
            this.CreateMap<Contract, EditedContractModel>();
            this.CreateMap<Contract, DeletedContractModel>();
            this.CreateMap<Contract, ContractListingModel>();
        }
    }
}
