namespace JaxWorld.Services.AutoMapperProfiles.Standard
{
    using AutoMapper;
    using Data.Entities.Blockchain;
    using Models.Responses.BlockchainResponses.StandardModels;
    using Models.Requests.BlockchainRequests.StandardModels;

    public class StandardMappingProfile : Profile
    {
        public StandardMappingProfile()
        {
            this.CreateMap<CreateStandardModel, Standard>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Standard, CreatedStandardModel>();
            this.CreateMap<Standard, EditedStandardModel>();
            this.CreateMap<Standard, DeletedStandardModel>();
            this.CreateMap<Standard, StandardListingModel>();
        }
    }
}
