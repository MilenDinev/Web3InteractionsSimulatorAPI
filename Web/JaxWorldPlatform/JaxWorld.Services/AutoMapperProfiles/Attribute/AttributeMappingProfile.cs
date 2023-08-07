namespace JaxWorld.Services.AutoMapperProfiles.Attribute
{
    using AutoMapper;
    using Data.Entities.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    public class AttributeMappingProfile : Profile
    {
        public AttributeMappingProfile()
        {
            this.CreateMap<CreateAttributeModel, Attribute>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.TraitType.ToUpper()));
            this.CreateMap<Attribute, CreatedAttributeModel>();
            this.CreateMap<Attribute, EditedAttributeModel>();
            this.CreateMap<Attribute, DeletedAttributeModel>();
            this.CreateMap<Attribute, AttributeListingModel>();
        }
    }
}
