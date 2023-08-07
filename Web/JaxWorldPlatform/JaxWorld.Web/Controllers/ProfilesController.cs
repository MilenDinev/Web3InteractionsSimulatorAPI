namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces;
    using Web.Controllers.Base;
    using Microsoft.AspNetCore.Mvc;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;
    using Profile = Data.Entities.Profiles.Profile;

    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : JaxWorldBaseController
    {
        private readonly IProfileService profileService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public ProfilesController(IProfileService profileService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.profileService = profileService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<ProfilesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<ProfileListingModel>>> Get()
        {
            var allProfiles = await this.finder.GetAllActiveAsync<Profile>();
            return mapper.Map<ICollection<ProfileListingModel>>(allProfiles).ToList();
        }

        // GET api/<ProfilesController>/Profile/5
        [HttpGet("Get/Profile/{profileId}")]
        public async Task<ActionResult<ProfileListingModel>> GetById(int profileId)
        {
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateEntityAsync(profile, profileId.ToString());
            return mapper.Map<ProfileListingModel>(profile);
        }

        // POST api/<ProfilesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateProfileModel profileInput)
        {
            await AssignCurrentUserAsync();
            var profile = await this.finder.FindByStringOrDefaultAsync<Profile>(profileInput.Name);
            await this.validator.ValidateUniqueEntityAsync(profile);

            profile = await this.profileService.CreateAsync(profileInput, CurrentUser.Id);
            var createdProfile = mapper.Map<CreatedProfileModel>(profile);

            return CreatedAtAction(nameof(Get), "Profiles", new { id = createdProfile.Id }, createdProfile);
        }


        // PUT api/<ProfilesController>/5
        [HttpPut("Edit/Profile/{profileId}")]
        public async Task<ActionResult<EditedProfileModel>> Edit(EditProfileModel profileInput, int profileId)
        {
            await AssignCurrentUserAsync();

            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateEntityAsync(profile, profileId.ToString());

            await this.profileService.EditAsync(profile, profileInput, CurrentUser.Id);

            return mapper.Map<EditedProfileModel>(profile);
        }

        // DELETE api/<ProfilesController>/Profile/5
        [HttpDelete("Delete/Profile/{profileId}")]
        public async Task<DeletedProfileModel> Delete(int profileId)
        {
            await AssignCurrentUserAsync();
            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(profileId);
            await this.validator.ValidateEntityAsync(profile, profileId.ToString());
            await this.profileService.DeleteAsync(profile, CurrentUser.Id);
            return mapper.Map<DeletedProfileModel>(profile);
        }
    }
}
