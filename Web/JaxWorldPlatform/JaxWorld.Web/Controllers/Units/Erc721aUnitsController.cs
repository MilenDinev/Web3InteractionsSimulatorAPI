namespace JaxWorld.Web.Controllers.Units
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities.Units;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces.Units;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class Erc721aUnitsController : JaxWorldBaseController
    {
        private readonly IErc721aUnitService unitService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public Erc721aUnitsController(IErc721aUnitService unitService,
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

        // GET: api/<Erc721aUnitsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<Erc721aUnitListingModel>>> Get()
        {
            var allUnits = await finder.GetAllActiveAsync<Erc721aUnit>();
            return mapper.Map<ICollection<Erc721aUnitListingModel>>(allUnits).ToList();
        }

        // GET api/<Erc721aUnitsController>/Erc721aUnit/5
        [HttpGet("Get/Erc721aUnit/{unitId}")]
        public async Task<ActionResult<Erc721aUnitListingModel>> GetById(int unitId)
        {
            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);
            await validator.ValidateEntityAsync(unit, unitId.ToString());
            return mapper.Map<Erc721aUnitListingModel>(unit);
        }

        // POST api/<Erc721aUnitsController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateErc721aUnitModel unitInput)
        {
            await AssignCurrentUserAsync();
            var unit = await finder.FindByStringOrDefaultAsync<Erc721aUnit>(unitInput.Name);
            await validator.ValidateUniqueEntityAsync(unit);

            unit = await unitService.CreateAsync(unitInput, CurrentUser.Id);
            var createdUnit = mapper.Map<CreatedErc721aUnitModel>(unit);

            return CreatedAtAction(nameof(Get), "Units", new { id = createdUnit.Id }, createdUnit);
        }

        // PUT api/<Erc721aUnitsController>/5
        [HttpPut("Edit/Erc721aUnit/{unitId}")]
        public async Task<ActionResult<EditedErc721aUnitModel>> Edit(EditErc721aUnitModel unitInput, int unitId)
        {
            await AssignCurrentUserAsync();

            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);
            await validator.ValidateEntityAsync(unit, unitId.ToString());

            await unitService.EditAsync(unit, unitInput, CurrentUser.Id);

            return mapper.Map<EditedErc721aUnitModel>(unit);
        }

        // DELETE api/<Erc721aUnitsController>/Unit/5
        [HttpDelete("Delete/Erc721aUnit/{unitId}")]
        public async Task<DeletedErc721aUnitModel> Delete(int unitId)
        {
            await AssignCurrentUserAsync();
            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);
            await validator.ValidateEntityAsync(unit, unitId.ToString());
            await unitService.DeleteAsync(unit, CurrentUser.Id);
            return mapper.Map<DeletedErc721aUnitModel>(unit);
        }
    }
}