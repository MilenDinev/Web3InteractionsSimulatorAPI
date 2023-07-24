namespace JaxWorld.Services.AutoMapperProfiles.Contract
{
    using AutoMapper;
    using Data.Entities.Blockchain.Contracts;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;

    public class ContractMappingProfile : Profile
    {
        public ContractMappingProfile()
        {
            this.CreateMap<CreateContractModel, Contract>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Contract, CreatedContractModel>();
            this.CreateMap<Contract, EditedContractModel>();
        }
    }
}
