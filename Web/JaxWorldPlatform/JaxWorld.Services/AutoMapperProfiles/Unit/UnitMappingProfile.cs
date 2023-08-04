namespace JaxWorld.Services.AutoMapperUnits.Unit
{
    using AutoMapper;
    using Unit = Data.Entities.Blockchain.Base.Unit;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;

    internal class UnitMappingUnit : Profile
    {
        internal UnitMappingUnit()
        {
            this.CreateMap<CreateErc721aUnitModel, Unit>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Unit, CreatedErc721aUnitModel>();
            this.CreateMap<Unit, EditedErc721aUnitModel>();
            this.CreateMap<Unit, DeletedErc721aUnitModel>();
            this.CreateMap<Unit, Erc721aUnitListingModel>();
        }
    }
}
