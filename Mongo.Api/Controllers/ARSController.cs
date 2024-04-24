using Mongo.Application.ARS.Queries;
using Mongo.Application.Common.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mongo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ARSController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ARSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Response<List<ARSResponse>>> Get()
        {
            return await _mediator.Send(new GetAllARSQuery());
        }
       
    }
}
