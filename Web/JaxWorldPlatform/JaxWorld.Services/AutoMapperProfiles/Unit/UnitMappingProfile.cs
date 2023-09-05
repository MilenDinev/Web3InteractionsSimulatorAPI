namespace JaxWorld.Services.AutoMapperProfiles.Unit
{
    using AutoMapper;
    using Data.Entities.Units;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public class UnitMappingProfile : Profile
    {
        public UnitMappingProfile()
        {
            this.CreateMap<CreateErc721aUnitModel, Erc721aUnit>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Erc721aUnit, CreatedErc721aUnitModel>()
                .ForMember(m => m.NetworkId, e => e.MapFrom(e => e.Profile.Contract.NetworkId))
                .ForMember(m => m.ContractId, e => e.MapFrom(e => e.Profile.ContractId))
                .ForMember(m => m.MinterId, e => e.MapFrom(e => e.Profile.Contract.CreatorWalletId))
                .ForMember(m => m.MinterAddress, e => e.MapFrom(e => "0x0000000000000000"));
            this.CreateMap<Erc721aUnit, EditedErc721aUnitModel>();
            this.CreateMap<Erc721aUnit, DeletedErc721aUnitModel>();
            this.CreateMap<Erc721aUnit, Erc721aUnitListingModel>();
        }
    }
}
