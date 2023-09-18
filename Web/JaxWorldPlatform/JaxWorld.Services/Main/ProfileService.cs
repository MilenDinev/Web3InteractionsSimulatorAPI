namespace JaxWorld.Services.Main
{
    using System.Collections.Generic;
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Contracts;
    using Interfaces;
    using Services.Constants;
    using Handlers.Exceptions;
    using Handlers.Interfaces;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Profile = Data.Entities.Profiles.Profile;

    public class ProfileService : BaseService<Profile>, IProfileService
    {
        private readonly IFinder finder;
        private readonly IMapper mapper;

        public ProfileService(JaxWorldDbContext dbContext,
            IFinder finder,
            IMapper mapper) : base(dbContext)
        {
            this.finder = finder;
            this.mapper = mapper;
        }

        public async Task<CreatedProfileModel> CreateAsync(CreateProfileModel profileModel, int creatorId)
        {
            await this.ValidateProfileCreateInputAsync(profileModel);

            var profile = mapper.Map<Profile>(profileModel);

            await CreateEntityAsync(profile, creatorId);

            return mapper.Map<CreatedProfileModel>(profile);
        }

        public async Task<EditedProfileModel> EditAsync(EditProfileModel profileModel, int profileId, int modifierId)
        {
            var profile = await this.GetProfileAsync(profileId);

            await SaveModificationAsync(profile, modifierId);

            return mapper.Map<EditedProfileModel>(profile);
        }

        public async Task<DeletedProfileModel> DeleteAsync(int profileId, int modifierId)
        {
            var profile = await this.GetProfileAsync(profileId);

            await DeleteEntityAsync(profile, modifierId);

            return mapper.Map<DeletedProfileModel>(profile);
        }

        public async Task<IEnumerable<ProfileListingModel>> GetAllActiveProfilesAsync()
        {
            var allProfiles = await this.finder.GetAllAsync<Profile>();

            return mapper.Map<ICollection<ProfileListingModel>>(allProfiles.Where(p => !p.Deleted)).ToList();
        }

        public async Task<ProfileListingModel> GetByIdAsync(int profileId)
        {
            var profile = await this.GetProfileAsync(profileId);

            return mapper.Map<ProfileListingModel>(profile);
        }

        public async Task<int> GetProfileNetworkIdAsync(int contractId)
        {
            var contract = await this.finder.FindByIdOrDefaultAsync<Contract>(contractId) 
                ?? throw new ResourceNotFoundException(string.Format(
                    ErrorMessages.EntityDoesNotExist,
                    typeof(Contract).Name));

            return contract.NetworkId;
        }

        private async Task<Profile> GetProfileAsync(int profileId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);

            if (profile != null)
                return profile;

            throw new ResourceNotFoundException(string.Format(
                ErrorMessages.EntityDoesNotExist, typeof(Profile).Name));
        }

        private async Task ValidateProfileCreateInputAsync(CreateProfileModel profileModel)
        {
            var IsProfileExists = await this.finder.AnyByStringAsync<Profile>(profileModel.Name);
            if (IsProfileExists)
                throw new ResourceAlreadyExistsException(string.Format(
                    ErrorMessages.NamedEntityAlreadyExists,
                    typeof(Profile).Name, profileModel.Name));

            var IsContractExists = await this.finder.AnyByIdAsync<Contract>(profileModel.ContractId);
            if (!IsContractExists)
                throw new ResourceNotFoundException(string.Format(
                    ErrorMessages.EntityDoesNotExist,
                    typeof(Contract).Name));
        }
    }
}
