using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.Management.Presentation.Api.Controllers
{
    [Route("api/v1/personLevels")]
    [ApiController]
    public class PersonLevelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonLevelsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Person>> Create([FromBody]CreatePersonLevelsRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);  
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<Person>> GetAll([FromQuery] GetAllPersonLevelsRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<ActionResult<Person>> GetById([FromQuery] GetPersonLevelsByIdRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Person>> Update([FromBody] UpdatePersonLevelsRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(DeletePersonLevelsRequest command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
