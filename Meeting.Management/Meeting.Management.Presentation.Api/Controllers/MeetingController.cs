using MediatR;
using Meeting.Management.Application.Commands.Request.Person;
using Meeting.Management.Application.Queries.Request.Person;
using Meeting.Management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Meeting.Management.Presentation.Api.Controllers
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
            var form = HttpContext.Request.Form;
            var file = form.Files.FirstOrDefault();

            if (file == null || file.Length == 0)
                return BadRequest("Invalid file");

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                command.Photo = memoryStream.ToArray();
            }

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
