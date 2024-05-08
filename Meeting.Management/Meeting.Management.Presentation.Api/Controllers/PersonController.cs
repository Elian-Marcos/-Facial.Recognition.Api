using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.Management.Presentation.Api.Controllers
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
        public async Task<ActionResult<Person>> Create([FromBody]CreatePersonRequest command)
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
        public async Task<ActionResult<Person>> GetAll([FromQuery] GetAllPersonRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("getById")]
        public async Task<ActionResult<Person>> GetById([FromQuery] GetPersonByIdRequest query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Person>> Update([FromBody] UpdatePersonRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(DeletePersonRequest command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
