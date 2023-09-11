namespace JaxWorld.Web.Controllers.Properties
{
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Services.Main.Interfaces;
    using Services.Main.Interfaces.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : JaxWorldBaseController
    {
        private readonly IAttributeService attributeService;

        public AttributesController(IAttributeService attributeService,
            IUserService userService)
            : base(userService)
        {
            this.attributeService = attributeService;
        }

        // GET: api/<AttributesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<AttributeListingModel>>> Get()
        {
            var allAttributes = await this.attributeService.GetAllActiveAttributesAsync();

            return allAttributes.ToList();
        }

        // GET api/<AttributesController>/Attribute/5
        [HttpGet("Get/Attribute/{attributeId}")]
        public async Task<ActionResult<AttributeListingModel>> GetById(int аttributeId)
        {
            var аttributeListingModel = await this.attributeService.GetByIdAsync(аttributeId);

            return аttributeListingModel;
        }

        // POST api/<AttributesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateAttributeModel аttributeInput)
        {
            await AssignCurrentUserAsync();

            var createdAttribute = await attributeService.CreateAsync(аttributeInput, CurrentUser.Id);

            return CreatedAtAction(nameof(Get), "Utilities", new { id = createdAttribute.Id }, createdAttribute);
        }

        // PUT api/<AttributesController>/5
        [HttpPut("Edit/Attribute/{attributeId}")]
        public async Task<ActionResult<EditedAttributeModel>> Edit(EditAttributeModel аttributeInput, int аttributeId)
        {
            await AssignCurrentUserAsync();

            var editedAttribute = await attributeService.EditAsync(аttributeInput, аttributeId, CurrentUser.Id);

            return editedAttribute;
        }

        // DELETE api/<AttributesController>/Attribute/5
        [HttpDelete("Delete/Attribute/{attributeId}")]
        public async Task<DeletedAttributeModel> Delete(int аttributeId)
        {
            await AssignCurrentUserAsync();

            var deletedAttributeModel = await attributeService.DeleteAsync(аttributeId, CurrentUser.Id);

            return deletedAttributeModel;
        }
    }
}
