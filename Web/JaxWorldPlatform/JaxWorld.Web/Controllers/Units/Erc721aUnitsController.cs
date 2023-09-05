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
    using Profile = Data.Entities.Profiles.Profile;
    using JaxWorld.Data.Entities.Wallets;


    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class Erc721aUnitsController : JaxWorldBaseController
    {
        private readonly IErc721aUnitService unitService;
        private readonly ITransactionDeployer transactionDeployer;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public Erc721aUnitsController(IErc721aUnitService unitService,
            ITransactionDeployer transactionDeployer,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.unitService = unitService;
            this.transactionDeployer = transactionDeployer;
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
            await validator.ValidateEntityAsync(unit);

            return mapper.Map<Erc721aUnitListingModel>(unit);
        }

        // POST api/<Erc721aUnitsController/Add>
        [HttpPost("Mint/")]
        public async Task<ActionResult> Post(CreateErc721aUnitModel unitInput)
        {
            await AssignCurrentUserAsync();

            var unit = await finder.FindByStringOrDefaultAsync<Erc721aUnit>(unitInput.Name);
            await validator.ValidateUniqueEntityAsync(unit);

            var profile = await this.finder.FindByIdOrDefaultAsync<Profile>(unitInput.ProfileId);
            await this.validator.ValidateEntityAsync(profile);

            var activeWallet = CurrentUser.Wallets.FirstOrDefault();

            await this.validator.ValidateProfileOwnershipAsync(activeWallet, profile.ContractId);

            var createdUnit = await unitService.CreateAsync(unitInput, CurrentUser.Id);
            var mintedUnit = await this.transactionDeployer.MintedErc721aUnitTxnAsync(createdUnit, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Erc721aUnits", new { id = mintedUnit.Id }, mintedUnit);
        }

        // PUT api/<Erc721aUnitsController>/5
        [HttpPut("Edit/Erc721aUnit/{unitId}")]
        public async Task<ActionResult<EditedErc721aUnitModel>> Put(EditErc721aUnitModel unitInput, int unitId)
        {
            await AssignCurrentUserAsync();

            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);

            await validator.ValidateEntityAsync(unit);
            await unitService.EditAsync(unit, unitInput, CurrentUser.Id);

            return mapper.Map<EditedErc721aUnitModel>(unit);
        }

        // DELETE api/<Erc721aUnitsController>/Unit/5
        [HttpDelete("Delete/Erc721aUnit/{unitId}")]
        public async Task<DeletedErc721aUnitModel> Delete(int unitId)
        {
            await AssignCurrentUserAsync();

            var unit = await finder.FindByIdOrDefaultAsync<Erc721aUnit>(unitId);

            await validator.ValidateEntityAsync(unit);
            await unitService.DeleteAsync(unit, CurrentUser.Id);

            return mapper.Map<DeletedErc721aUnitModel>(unit);
        }
    }
}