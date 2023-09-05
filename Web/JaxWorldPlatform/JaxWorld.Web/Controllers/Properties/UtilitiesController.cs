namespace JaxWorld.Web.Controllers.Properties
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities.Properties;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;

    [Route("api/[controller]")]
    [ApiController]
    public class UtilitiesController : JaxWorldBaseController
    {
        private readonly IUtilityService utilityService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public UtilitiesController(IUtilityService utilityService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.utilityService = utilityService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<UtilitiesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<UtilityListingModel>>> Get()
        {
            var allUtilities = await finder.GetAllActiveAsync<Utility>();

            return mapper.Map<ICollection<UtilityListingModel>>(allUtilities).ToList();
        }

        // GET api/<UtilitiesController>/Utility/5
        [HttpGet("Get/Utility/{utilityId}")]
        public async Task<ActionResult<UtilityListingModel>> GetById(int utilityId)
        {
            var utility = await finder.FindByIdOrDefaultAsync<Utility>(utilityId);
            await validator.ValidateEntityAsync(utility);

            return mapper.Map<UtilityListingModel>(utility);
        }

        // POST api/<UtilitiesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateUtilityModel utilityInput)
        {
            await AssignCurrentUserAsync();

            var utility = await finder.FindByStringOrDefaultAsync<Utility>(utilityInput.TraitType);
            await validator.ValidateUniqueEntityAsync(utility);

            utility = await utilityService.CreateAsync(utilityInput, CurrentUser.Id);
            var createdUtility = mapper.Map<CreatedUtilityModel>(utility);

            return CreatedAtAction(nameof(Get), "Utilities", new { id = createdUtility.Id }, createdUtility);
        }

        // PUT api/<UtilitiesController>/5
        [HttpPut("Edit/Utility/{utilityId}")]
        public async Task<ActionResult<EditedUtilityModel>> Edit(EditUtilityModel utilityInput, int utilityId)
        {
            await AssignCurrentUserAsync();

            var utility = await finder.FindByIdOrDefaultAsync<Utility>(utilityId);
            await validator.ValidateEntityAsync(utility);

            await utilityService.EditAsync(utility, utilityInput, CurrentUser.Id);

            return mapper.Map<EditedUtilityModel>(utility);
        }

        // DELETE api/<UtilitiesController>/Utility/5
        [HttpDelete("Delete/Utility/{utilityId}")]
        public async Task<DeletedUtilityModel> Delete(int utilityId)
        {
            await AssignCurrentUserAsync();

            var utility = await finder.FindByIdOrDefaultAsync<Utility>(utilityId);

            await validator.ValidateEntityAsync(utility);
            await utilityService.DeleteAsync(utility, CurrentUser.Id);

            return mapper.Map<DeletedUtilityModel>(utility);
        }
    }
}
