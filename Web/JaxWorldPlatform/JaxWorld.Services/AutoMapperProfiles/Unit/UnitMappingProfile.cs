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
            this.CreateMap<CreateUnitModel, Unit>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Unit, CreatedUnitModel>();
            this.CreateMap<Unit, EditedUnitModel>();
            this.CreateMap<Unit, DeletedUnitModel>();
            this.CreateMap<Unit, UnitListingModel>();
        }
    }
}
