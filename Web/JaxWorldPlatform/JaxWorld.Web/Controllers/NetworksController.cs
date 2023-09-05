namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class NetworksController : JaxWorldBaseController
    {
        private readonly INetworkService networkService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public NetworksController(INetworkService networkService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.networkService = networkService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<NetworksController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<NetworkListingModel>>>Get()
        {
            var allNetworks = await this.finder.GetAllActiveAsync<Network>();

            return mapper.Map<ICollection<NetworkListingModel>>(allNetworks).ToList();
        }

        // GET api/<NetworksController>/Network/5
        [HttpGet("Get/Network/{networkId}")]
        public async Task<ActionResult<NetworkListingModel>> GetById(int networkId)
        {
            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);
            await this.validator.ValidateEntityAsync(network, networkId.ToString());

            return mapper.Map<NetworkListingModel>(network);
        }

        // POST api/<NetworksController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateNetworkModel networkInput)
        {
            await AssignCurrentUserAsync();

            var network = await this.finder.FindByStringOrDefaultAsync<Network>(networkInput.Name);
            await this.validator.ValidateUniqueEntityAsync(network);

            network = await this.networkService.CreateAsync(networkInput, CurrentUser.Id);
            var createdNetwork = mapper.Map<CreatedNetworkModel>(network);

            return CreatedAtAction(nameof(Get), "Networks", new { id = createdNetwork.Id }, createdNetwork);
        }

        // PUT api/<NetworksController>/5
        [HttpPut("Edit/Network/{networkId}")]
        public async Task<ActionResult<EditedNetworkModel>> Edit(EditNetworkModel networkInput, int networkId)
        {
            await AssignCurrentUserAsync();

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);

            await this.validator.ValidateEntityAsync(network, networkId.ToString());
            await this.networkService.EditAsync(network, networkInput, CurrentUser.Id);

            return mapper.Map<EditedNetworkModel>(network);
        }

        // DELETE api/<NetworksController>/Network/5
        [HttpDelete("Delete/Network/{networkId}")]
        public async Task<DeletedNetworkModel> Delete(int networkId)
        {
            await AssignCurrentUserAsync();

            var network = await this.finder.FindByIdOrDefaultAsync<Network>(networkId);

            await this.validator.ValidateEntityAsync(network, networkId.ToString());
            await this.networkService.DeleteAsync(network, CurrentUser.Id);

            return mapper.Map<DeletedNetworkModel>(network);
        }
    }
}

//[HttpPost]
//public void Post([FromBody] string value)
//{
//}
