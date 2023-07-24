namespace JaxWorld.Web.Controllers
{
    using AutoMapper;
    using Services.Main.Interfaces;
    using Services.Handlers.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Base;
    using Data.Entities.Blockchain;
    using Models.Requests.BlockchainRequests.ChainModels;
    using Models.Responses.BlockchainResponses.ChainModels;
    using Microsoft.AspNetCore.HttpOverrides;

    // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    [Route("api/[controller]")]
    [ApiController]
    public class NetworksController : JaxWorldBaseController
    {

    }
}

