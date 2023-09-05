namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Profile = Data.Entities.Profiles.Profile;
    using Models.Requests.BlockchainRequests.ProfileModels;

    public class ProfileService : BaseService<Profile>, IProfileService
    {
        private readonly IMapper mapper;

        public ProfileService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Profile> CreateAsync(CreateProfileModel profileModel, int creatorId)
        {
            var profile = mapper.Map<Profile>(profileModel);

            await CreateEntityAsync(profile, creatorId);

            return profile;
        }

        public async Task EditAsync(Profile profile, EditProfileModel profileModel, int modifierId)
        {
            profile.Name = profileModel.Name;

            await SaveModificationAsync(profile, modifierId);
        }

        public async Task DeleteAsync(Profile profile, int modifierId)
        {
            await DeleteEntityAsync(profile, modifierId);
        }
    }
}
