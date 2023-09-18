namespace JaxWorld.Web.Controllers.Units
{
    using AutoMapper;
    using Base;
    using Microsoft.AspNetCore.Mvc;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Services.Main.Interfaces;
    using Services.Main.Interfaces.Units;


    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class Erc721aUnitsController : JaxWorldBaseController
    {
        private readonly IErc721aUnitService unitService;
        private readonly IMapper mapper;

        public Erc721aUnitsController(IErc721aUnitService unitService,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.unitService = unitService;
            this.mapper = mapper;
        }

        // GET: api/<Erc721aUnitsController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<Erc721aUnitListingModel>>> Get()
        {
            var allUnits = await unitService.GetAllActiveErc721aUnitsAsync();

            return allUnits.ToList();
        }

        // GET api/<Erc721aUnitsController>/Erc721aUnit/5
        [HttpGet("Get/Erc721aUnit/{unitId}")]
        public async Task<ActionResult<Erc721aUnitListingModel>> GetById(int unitId)
        {
            var unitListingModel = await unitService.GetByIdAsync(unitId);

            return unitListingModel;
        }

        // POST api/<Erc721aUnitsController/Add>
        [HttpPost("Mint/")]
        public async Task<ActionResult> Post(CreateErc721aUnitModel unitInput)
        {
            await AssignCurrentUserAsync();

            var createdUnit = await unitService.CreateAsync(unitInput, CurrentUser);

            return CreatedAtAction(nameof(Get), "Erc721aUnits", new { id = createdUnit.Id }, createdUnit);
        }

        // PUT api/<Erc721aUnitsController>/5
        [HttpPut("Edit/Erc721aUnit/{unitId}")]
        public async Task<ActionResult<EditedErc721aUnitModel>> Put(EditErc721aUnitModel unitInput, int unitId)
        {
            await AssignCurrentUserAsync();

            var editedUnit = await unitService.EditAsync(unitInput, unitId, CurrentUser.Id);

            return editedUnit;
        }

        // DELETE api/<Erc721aUnitsController>/Unit/5
        [HttpDelete("Delete/Erc721aUnit/{unitId}")]
        public async Task<DeletedErc721aUnitModel> Delete(int unitId)
        {
            await AssignCurrentUserAsync();

            var deletedUnit = await unitService.DeleteAsync(unitId, CurrentUser.Id);

            return deletedUnit;
        }
    }
}