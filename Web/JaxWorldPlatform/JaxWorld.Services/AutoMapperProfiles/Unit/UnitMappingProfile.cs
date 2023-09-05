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
            this.CreateMap<Erc721aUnit, CreatedErc721aUnitModel>();
            this.CreateMap<Erc721aUnit, EditedErc721aUnitModel>();
            this.CreateMap<Erc721aUnit, DeletedErc721aUnitModel>();
            this.CreateMap<Erc721aUnit, Erc721aUnitListingModel>();
        }
    }
}
