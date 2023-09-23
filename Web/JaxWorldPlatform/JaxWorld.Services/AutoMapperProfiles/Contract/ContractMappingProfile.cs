namespace JaxWorld.Services.AutoMapperProfiles.Contract
{
    using System.Globalization;
    using Models.Requests.BlockchainRequests.ContractModels;
    using Models.Responses.BlockchainResponses.ContractModels;
    using JaxWorld.Data.Entities;
    using Profile = AutoMapper.Profile;

    public class ContractMappingProfile : Profile
    {
        public ContractMappingProfile()
        {
            this.CreateMap<CreateContractModel, Contract>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()))
                .ForMember(e => e.CreatorWalletId, m => m.Ignore());
            this.CreateMap<Contract, CreatedContractModel>();
            this.CreateMap<Contract, EditedContractModel>();
            this.CreateMap<Contract, DeletedContractModel>();
            this.CreateMap<Contract, ContractListingModel>()
                .ForMember(m => m.CreatorAddress, e => e.MapFrom(e => e.CreatorWallet.Address))
                .ForMember(m => m.Balance, e => e.MapFrom(e => e.Balance.ToString("F", CultureInfo.InvariantCulture) + " AVAX"))
                .ForMember(m => m.EstimatedValue, e => e.MapFrom(e => "$" + (e.EstimatedValue).ToString("F", CultureInfo.InvariantCulture)));
        }
    }
}
