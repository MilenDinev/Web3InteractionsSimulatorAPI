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
    using Models.Responses.BlockchainResponses.PropertiesModels.Attribute;

    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : JaxWorldBaseController
    {
        private readonly IAttributeService attributeService;
        private readonly IFinder finder;
        private readonly IValidator validator;
        private readonly IMapper mapper;

        public AttributesController(IAttributeService attributeService,
            IFinder finder,
            IValidator validator,
            IMapper mapper,
            IUserService userService)
            : base(userService)
        {
            this.attributeService = attributeService;
            this.finder = finder;
            this.validator = validator;
            this.mapper = mapper;
        }

        // GET: api/<AttributesController>
        [HttpGet("List/")]
        public async Task<ActionResult<IEnumerable<AttributeListingModel>>> Get()
        {
            var allAttributes = await finder.GetAllActiveAsync<Attribute>();
            return mapper.Map<ICollection<AttributeListingModel>>(allAttributes).ToList();
        }

        // GET api/<AttributesController>/Attribute/5
        [HttpGet("Get/Attribute/{attributeId}")]
        public async Task<ActionResult<AttributeListingModel>> GetById(int attributeId)
        {
            var attribute = await finder.FindByIdOrDefaultAsync<Attribute>(attributeId);
            await validator.ValidateEntityAsync(attribute, attributeId.ToString());
            return mapper.Map<AttributeListingModel>(attribute);
        }

        // POST api/<AttributesController/Add>
        [HttpPost("Add/")]
        public async Task<ActionResult> Create(CreateAttributeModel attributeInput)
        {
            await AssignCurrentUserAsync();
            var attribute = await finder.FindByStringOrDefaultAsync<Attribute>(attributeInput.TraitType);
            await validator.ValidateUniqueEntityAsync(attribute);

            attribute = await attributeService.CreateAsync(attributeInput, CurrentUser.Id);
            var createdAttribute = mapper.Map<CreatedAttributeModel>(attribute);

            return CreatedAtAction(nameof(Get), "Attributes", new { id = createdAttribute.Id }, createdAttribute);
        }

        // PUT api/<AttributesController>/5
        [HttpPut("Edit/Attribute/{attributeId}")]
        public async Task<ActionResult<EditedAttributeModel>> Edit(EditAttributeModel attributeInput, int attributeId)
        {
            await AssignCurrentUserAsync();

            var attribute = await finder.FindByIdOrDefaultAsync<Attribute>(attributeId);
            await validator.ValidateEntityAsync(attribute, attributeId.ToString());

            await attributeService.EditAsync(attribute, attributeInput, CurrentUser.Id);

            return mapper.Map<EditedAttributeModel>(attribute);
        }

        // DELETE api/<AttributesController>/Attribute/5
        [HttpDelete("Delete/Attribute/{attributeId}")]
        public async Task<DeletedAttributeModel> Delete(int attributeId)
        {
            await AssignCurrentUserAsync();
            var attribute = await finder.FindByIdOrDefaultAsync<Attribute>(attributeId);
            await validator.ValidateEntityAsync(attribute, attributeId.ToString());
            await attributeService.DeleteAsync(attribute, CurrentUser.Id);
            return mapper.Map<DeletedAttributeModel>(attribute);
        }
    }
}
