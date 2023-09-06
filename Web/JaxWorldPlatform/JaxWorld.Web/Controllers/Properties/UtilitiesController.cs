namespace JaxWorld.Web.Controllers.Properties
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Services.Main.Interfaces.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;

    [Route("api/[controller]")]
    [ApiController]
    public class UtilitiesController : JaxWorldBaseController
    {
        private readonly IUtilityService utilityService;
        private readonly IMapper mapper;

        public UtilitiesController(IUtilityService utilityService,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.utilityService = utilityService;
            this.mapper = mapper;
        }

        // GET: api/<UtilitiesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<UtilityListingModel>>> Get()
        {
            var allUtilities = await this.utilityService.GetAllActiveAsync();

            return allUtilities.ToList();
        }

        // GET api/<UtilitiesController>/Utility/5
        [HttpGet("Get/Utility/{utilityId}")]
        public async Task<ActionResult<UtilityListingModel>> GetById(int utilityId)
        {
            var utilityListingModel = await this.utilityService.GetByIdAsync(utilityId);

            return utilityListingModel;
        }

        // POST api/<UtilitiesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateUtilityModel utilityInput)
        {
            await AssignCurrentUserAsync();

            var createdUtility = await utilityService.CreateAsync(utilityInput, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Utilities", new { id = createdUtility.Id }, createdUtility);
        }

        // PUT api/<UtilitiesController>/5
        [HttpPut("Edit/Utility/{utilityId}")]
        public async Task<ActionResult<EditedUtilityModel>> Edit(EditUtilityModel utilityInput, int utilityId)
        {
            await AssignCurrentUserAsync();

            var editedUtility = await utilityService.EditAsync(utilityInput, utilityId, CurrentUser.Id);

            return editedUtility;
        }

        // DELETE api/<UtilitiesController>/Utility/5
        [HttpDelete("Delete/Utility/{utilityId}")]
        public async Task<DeletedUtilityModel> Delete(int utilityId)
        {
            await AssignCurrentUserAsync();

            var deletedUtilityModel = await utilityService.DeleteAsync(utilityId, CurrentUser.Id);

            return deletedUtilityModel;
        }
    }
}
