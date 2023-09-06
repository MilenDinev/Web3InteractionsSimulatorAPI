namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Models.Requests.BlockchainRequests.NetworkModels;
    using Models.Responses.BlockchainResponses.NetworkModels;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class NetworksController : JaxWorldBaseController
    {
        private readonly INetworkService networkService;
        private readonly IMapper mapper;

        public NetworksController(INetworkService networkService,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.networkService = networkService;

            this.mapper = mapper;
        }

        // GET: api/<NetworksController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<NetworkListingModel>>>Get()
        {
            var allNetworks = await this.networkService.GetGetAllActiveAsync();

            return allNetworks.ToList();
        }

        // GET api/<NetworksController>/Network/5
        [HttpGet("Get/Network/{networkId}")]
        public async Task<ActionResult<NetworkListingModel>> GetById(int networkId)
        {
            var networkListingModel = await this.networkService.GetByIdAsync(networkId);

            return networkListingModel;
        }

        // POST api/<NetworksController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateNetworkModel networkInput)
        {
            await AssignCurrentUserAsync();

            var createdNetwork = await this.networkService.CreateAsync(networkInput, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Networks", new { id = createdNetwork.Id }, createdNetwork);
        }

        // PUT api/<NetworksController>/5
        [HttpPut("Edit/Network/{networkId}")]
        public async Task<ActionResult<EditedNetworkModel>> Edit(EditNetworkModel networkInput, int networkId)
        {
            await AssignCurrentUserAsync();

            var editedNetwork = await this.networkService.EditAsync(networkInput, networkId, CurrentUser.Id);

            return editedNetwork;
        }

        // DELETE api/<NetworksController>/Network/5
        [HttpDelete("Delete/Network/{networkId}")]
        public async Task<DeletedNetworkModel> Delete(int networkId)
        {
            await AssignCurrentUserAsync();

            var deletedNetwork = await this.networkService.DeleteAsync(networkId, CurrentUser.Id);

            return deletedNetwork;
        }
    }
}

//[HttpPost]
//public void Post([FromBody] string value)
//{
//}
