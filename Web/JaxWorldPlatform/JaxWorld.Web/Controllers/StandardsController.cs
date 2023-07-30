namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Web.Controllers.Base;
    using Data.Entities.Blockchain;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Models.Requests.BlockchainRequests.StandardModels;
    using Models.Responses.BlockchainResponses.StandardModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class StandardsController : JaxWorldBaseController
    {
        private readonly IStandardService standardService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public StandardsController(IStandardService standardService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.standardService = standardService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<StandardsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<StandardListingModel>>> Get()
        {
            var allStandards = await this.finder.GetAllActiveAsync<Standard>();
            return mapper.Map<ICollection<StandardListingModel>>(allStandards).ToList();
        }

        // GET api/<StandardsController>/Standard/5
        [HttpGet("Get/Standard/{standardId}")]
        public async Task<ActionResult<StandardListingModel>> GetById(int standardId)
        {
            var standard = await this.finder.FindByIdOrDefaultAsync<Standard>(standardId);
            await this.validator.ValidateEntityAsync(standard, standardId.ToString());
            return mapper.Map<StandardListingModel>(standard);
        }

        // POST api/<StandardsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateStandardModel standardInput)
        {
            await AssignCurrentUserAsync();
            var standard = await this.finder.FindByStringOrDefaultAsync<Standard>(standardInput.Name);
            await this.validator.ValidateUniqueEntityAsync(standard);

            standard = await this.standardService.CreateAsync(standardInput, CurrentUser.Id);
            var createdStandard = mapper.Map<CreatedStandardModel>(standard);

            return CreatedAtAction(nameof(Get), "Standards", new { id = createdStandard.Id }, createdStandard);
        }

        // PUT api/<StandardsController>/5
        [HttpPut("Edit/Standard/{standardId}")]
        public async Task<ActionResult<EditedStandardModel>> Edit(EditStandardModel standardInput, int standardId)
        {
            await AssignCurrentUserAsync();

            var standard = await this.finder.FindByIdOrDefaultAsync<Standard>(standardId);
            await this.validator.ValidateEntityAsync(standard, standardId.ToString());

            await this.standardService.EditAsync(standard, standardInput, CurrentUser.Id);

            return mapper.Map<EditedStandardModel>(standard);
        }

        // DELETE api/<StandardsController>/Standard/5
        [HttpDelete("Delete/Standard/{standardId}")]
        public async Task<DeletedStandardModel> Delete(int standardId)
        {
            await AssignCurrentUserAsync();
            var standard = await this.finder.FindByIdOrDefaultAsync<Standard>(standardId);
            await this.validator.ValidateEntityAsync(standard, standardId.ToString());
            await this.standardService.DeleteAsync(standard, CurrentUser.Id);
            return mapper.Map<DeletedStandardModel>(standard);
        }
    }
}
