namespace JaxWorld.Services.Main
{
    using System.Collections.Generic;
    using AutoMapper;
    using Base;
    using Interfaces;
    using Handlers.Interfaces;
    using Profile = Data.Entities.Profiles.Profile;
    using Data;
    using Data.Entities;
    using Data.Entities.Contracts;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    public class ProfileService : BaseService<Profile>, IProfileService
    {
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public ProfileService(JaxWorldDbContext dbContext,
            IFinder finder,
            IValidator validator,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        public async Task<CreatedProfileModel> CreateAsync(CreateProfileModel profileModel, int creatorId)
        {
            var profile = await this.finder.FindByStringOrDefaultAsync<Profile>(profileModel.Name);
            await this.validator.ValidateUniqueEntityAsync(profile);

            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(profileModel.ContractId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(contract);

            var standard = await this.finder.FindByIdOrDefaultAsync<Standard>(profileModel.StandardId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(standard);

            profile = mapper.Map<Profile>(profileModel);

            await CreateEntityAsync(profile, creatorId);

            var createdProfile = mapper.Map<CreatedProfileModel>(profile);

            return createdProfile;
        }

        public async Task<EditedProfileModel> EditAsync(EditProfileModel profileModel, int profileId, int modifierId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(profile);

            profile.Name = profileModel.Name ?? profile.Name;

            await SaveModificationAsync(profile, modifierId);

            return mapper.Map<EditedProfileModel>(profile);
        }

        public async Task<DeletedProfileModel> DeleteAsync(int profileId, int modifierId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(profile);

            await DeleteEntityAsync(profile, modifierId);

            return mapper.Map<DeletedProfileModel>(profile);
        }

        public async Task<IEnumerable<ProfileListingModel>> GetAllActiveAsync()
        {
            var allProfiles = await this.finder.GetAllActiveAsync<Profile>();

            return mapper.Map<ICollection<ProfileListingModel>>(allProfiles).ToList();
        }

        public async Task<ProfileListingModel> GetByIdAsync(int profileId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateTargetEntityAvailabilityAsync(profile);

            return mapper.Map<ProfileListingModel>(profile);
        }
    }
}
