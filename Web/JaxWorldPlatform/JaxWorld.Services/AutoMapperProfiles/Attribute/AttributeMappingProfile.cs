namespace JaxWorld.Services.AutoMapperProfiles.Attribute
{
    using AutoMapper;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    internal class AttributeMappingProfile : Profile
    {
        internal AttributeMappingProfile()
        {
            this.CreateMap<CreateAttributeModel, Attribute>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Attribute, CreatedAttributeModel>();
            this.CreateMap<Attribute, EditedAttributeModel>();
            this.CreateMap<Attribute, DeletedAttributeModel>();
            this.CreateMap<Attribute, AttributeListingModel>();
        }
    }
}
