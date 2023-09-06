﻿namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces;
    using Models.Requests.BlockchainRequests.ProfileModels;
    using Models.Responses.BlockchainResponses.ProfileModels;

    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : JaxWorldBaseController
    {
        private readonly IProfileService profileService;
        private readonly ITransactionDeployer transactionDeployer;

        private readonly IMapper mapper;

        public ProfilesController(IProfileService profileService,
            ITransactionDeployer transactionDeployer,

            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.profileService = profileService;
            this.transactionDeployer = transactionDeployer;

            this.mapper = mapper;
        }

        // GET: api/<ProfilesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<ProfileListingModel>>> Get()
        {
            var allProfiles = await this.profileService.GetAllActiveAsync();

            return allProfiles.ToList();
        }

        // GET api/<ProfilesController>/Profile/5
        [HttpGet("Get/Profile/{profileId}")]
        public async Task<ActionResult<ProfileListingModel>> GetById(int profileId)
        {
            var profileListingModel = await this.profileService.GetByIdAsync(profileId);

            return profileListingModel;
        }

        // POST api/<ProfilesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateProfileModel profileInput)
        {
            await AssignCurrentUserAsync();

            var createdProfile = await this.profileService.CreateAsync(profileInput, CurrentUser.Id);

            var deployedProfile = await this.transactionDeployer.DeployProfileTxnAsync(createdProfile, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Profiles", new { id = deployedProfile.ProfileId }, deployedProfile);
        }


        // PUT api/<ProfilesController>/5
        [HttpPut("Edit/Profile/{profileId}")]
        public async Task<ActionResult<EditedProfileModel>> Edit(EditProfileModel profileInput, int profileId)
        {
            await AssignCurrentUserAsync();

            var editedProfile = await this.profileService.EditAsync(profileInput, profileId, CurrentUser.Id);

            return editedProfile;
        }

        // DELETE api/<ProfilesController>/Profile/5
        [HttpDelete("Delete/Profile/{profileId}")]
        public async Task<DeletedProfileModel> Delete(int profileId)
        {
            await AssignCurrentUserAsync();

            var deletedProfile = await this.profileService.DeleteAsync(profileId, CurrentUser.Id);

            return deletedProfile;
        }
    }
}
