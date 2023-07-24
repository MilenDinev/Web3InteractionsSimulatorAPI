namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Data;
    using Data.Entities.Blockchain.ProfileUnits.Base;
    using Models.Requests.BlockchainRequests.ProfileUnitModels;

    internal class ProfileUnitService : BaseService<ProfileUnit>
    {
        private readonly IMapper mapper;

        public ProfileUnitService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<ProfileUnit> CreateAsync(CreateProfileUnitModel profileUnitModel, int creatorId)
        {
            var profileUnit = mapper.Map<ProfileUnit>(profileUnitModel);
            await CreateEntityAsync(profileUnit, creatorId);
            return profileUnit;
        }

        public async Task EditAsync(ProfileUnit profileUnit, EditProfileUnitModel profileUnitModel, int modifierId)
        {
            profileUnit.Name = profileUnitModel.Name;

            await SaveModificationAsync(profileUnit, modifierId);
        }
        public async Task DeleteAsync(ProfileUnit profileUnit, int modifierId)
        {
            await DeleteEntityAsync(profileUnit, modifierId);
        }
    }
}
