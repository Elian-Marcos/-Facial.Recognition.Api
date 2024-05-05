using MediatR;
using Meeting.Management.Application.Commands.Request;
using Meeting.Management.Application.Queries.Request;
using Meeting.Management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Meeting.Management.Presentation.Api.Controllers
{
    [Route("api/v1/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Person>> Create(CreatePersonRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);  
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<Person>> GetAll()
        {
            var query = new GetAllPersonRequest();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
