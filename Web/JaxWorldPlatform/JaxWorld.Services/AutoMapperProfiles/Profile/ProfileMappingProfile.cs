namespace JaxWorld.Services.AutoMapperProfiles.Profile
{
    using Data.Entities.Profiles;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileMappingProfile : AutoMapper.Profile
    {
        public ProfileMappingProfile()
        {
            this.CreateMap<CreateProfileModel, Profile>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Name.ToUpper()))
                .ForMember(e => e.ContractId, m => m.Ignore())
                .ForMember(e => e.StandardId, m => m.Ignore());
            this.CreateMap<Profile, CreatedProfileModel>()
                .ForMember(m => m.CreatorWalletId, e => e.MapFrom(e => e.Contract.CreatorWalletId))
                .ForMember(m => m.NetworkId, e => e.MapFrom(e => e.Contract.NetworkId));
            this.CreateMap<Profile, EditedProfileModel>();
            this.CreateMap<Profile, DeletedProfileModel>();
            this.CreateMap<Profile, ProfileListingModel>();
        }
    }
}
