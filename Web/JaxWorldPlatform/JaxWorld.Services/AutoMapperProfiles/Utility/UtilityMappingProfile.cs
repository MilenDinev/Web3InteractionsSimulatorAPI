namespace JaxWorld.Services.AutoMapperProfiles.Utility
{
    using AutoMapper;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;

    public class UtilityMappingProfile : Profile
    {
        public UtilityMappingProfile()
        {
            this.CreateMap<CreateUtilityModel, Utility>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.TraitType.ToUpper()));
            this.CreateMap<Utility, CreatedUtilityModel>();
            this.CreateMap<Utility, EditedUtilityModel>();
            this.CreateMap<Utility, DeletedUtilityModel>();
            this.CreateMap<Utility, UtilityListingModel>();
        }
    }
}
