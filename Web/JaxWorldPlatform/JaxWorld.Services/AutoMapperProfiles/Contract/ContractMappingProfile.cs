namespace JaxWorld.Services.AutoMapperProfiles.Contract
{
    using System.Globalization;
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
                .ForMember(e => e.CreatorWalletId, m => m.MapFrom(m => 1));
            this.CreateMap<Contract, CreatedContractModel>()
                .ForMember(e => e.Creator, m => m.MapFrom(m => m.Creator.UserName))
                .ForMember(e => e.CreatorWallet, m => m.MapFrom(m => m.CreatorWallet.Address));
            this.CreateMap<Contract, EditedContractModel>();
            this.CreateMap<Contract, DeletedContractModel>();
            this.CreateMap<Contract, ContractListingModel>()
                .ForMember(m => m.CreatorAddress, e => e.MapFrom(e => e.CreatorWallet.Address))
                .ForMember(m => m.Balance, e => e.MapFrom(e => e.Balance.ToString("F", CultureInfo.InvariantCulture) + " AVAX"))
                .ForMember(m => m.EstimatedValue, e => e.MapFrom(e => "$" + (e.EstimatedValue).ToString("F", CultureInfo.InvariantCulture)));
        }
    }
}
