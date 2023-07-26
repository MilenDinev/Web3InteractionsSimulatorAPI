namespace JaxWorld.Services.AutoMapperProfiles.Profile
{
    using Data.Entities.Blockchain.Base;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    internal class ProfileMappingProfile : AutoMapper.Profile
    {
        internal ProfileMappingProfile()
        {
            this.CreateMap<CreateProfileModel, Profile>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Profile, CreatedProfileModel>();
            this.CreateMap<Profile, EditedProfileModel>();
            this.CreateMap<Profile, DeletedProfileModel>();
            this.CreateMap<Profile, ProfileListingModel>();
        }
    }
}
