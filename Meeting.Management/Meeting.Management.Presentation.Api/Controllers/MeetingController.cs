using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.Management.Presentation.Api.Controllers
{
    [Route("api/v1/meetings")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeetingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Meeting>> Create([FromBody]CreateMeetingRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);  
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<Meeting>> GetAll([FromQuery] GetAllMeetingRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<ActionResult<Meeting>> GetById([FromQuery] GetMeetingByIdRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Meeting>> Update([FromBody] UpdateMeetingRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(DeleteMeetingRequest command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
