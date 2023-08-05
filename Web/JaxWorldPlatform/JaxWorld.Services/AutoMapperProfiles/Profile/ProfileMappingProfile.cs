namespace JaxWorld.Services.AutoMapperProfiles.Profile
{
    using Data.Entities.Blockchain.Profiles;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileMappingProfile : AutoMapper.Profile
    {
        public ProfileMappingProfile()
        {
            this.CreateMap<CreateProfileModel, Profile>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Profile, CreatedProfileModel>();
            this.CreateMap<Profile, EditedProfileModel>();
            this.CreateMap<Profile, DeletedProfileModel>();
            this.CreateMap<Profile, ProfileListingModel>();
        }
    }
}
