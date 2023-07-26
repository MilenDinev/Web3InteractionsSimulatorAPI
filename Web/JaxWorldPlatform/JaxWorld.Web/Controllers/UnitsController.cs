namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Data.Entities.Blockchain.Base;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : JaxWorldBaseController
    {
        private readonly IUnitService unitService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public UnitsController(IUnitService unitService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.unitService = unitService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<UnitsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<UnitListingModel>>> Get()
        {
            var allUnits = await this.finder.GetAllActiveAsync<Unit>();
            return mapper.Map<ICollection<UnitListingModel>>(allUnits).ToList();
        }

        // GET api/<UnitsController>/Unit/5
        [HttpGet("Get/Unit/{unitId}")]
        public async Task<ActionResult<UnitListingModel>> GetById(int unitId)
        {
            var unit = await this.finder.FindByIdOrDefaultAsync<Unit>(unitId);
            await this.validator.ValidateEntityAsync(unit, unitId.ToString());
            return mapper.Map<UnitListingModel>(unit);
        }

        // POST api/<UnitsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateUnitModel unitInput)
        {
            await AssignCurrentUserAsync();
            var unit = await this.finder.FindByStringOrDefaultAsync<Unit>(unitInput.Name);
            await this.validator.ValidateUniqueEntityAsync(unit);

            unit = await this.unitService.CreateAsync(unitInput, CurrentUser.Id);
            var createdUnit = mapper.Map<CreatedUnitModel>(unit);

            return CreatedAtAction(nameof(Get), "Units", new { id = createdUnit.Id }, createdUnit);
        }

        // PUT api/<UnitsController>/5
        [HttpPut("Edit/Unit/{unitId}")]
        public async Task<ActionResult<EditedUnitModel>> Edit(EditUnitModel unitInput, int unitId)
        {
            await AssignCurrentUserAsync();

            var unit = await this.finder.FindByIdOrDefaultAsync<Unit>(unitId);
            await this.validator.ValidateEntityAsync(unit, unitId.ToString());

            await this.unitService.EditAsync(unit, unitInput, CurrentUser.Id);

            return mapper.Map<EditedUnitModel>(unit);
        }

        // DELETE api/<UnitsController>/Unit/5
        [HttpDelete("Delete/Unit/{unitId}")]
        public async Task<DeletedUnitModel> Delete(int unitId)
        {
            await AssignCurrentUserAsync();
            var unit = await this.finder.FindByIdOrDefaultAsync<Unit>(unitId);
            await this.validator.ValidateEntityAsync(unit, unitId.ToString());
            await this.unitService.DeleteAsync(unit, CurrentUser.Id);
            return mapper.Map<DeletedUnitModel>(unit);
        }
    }
}