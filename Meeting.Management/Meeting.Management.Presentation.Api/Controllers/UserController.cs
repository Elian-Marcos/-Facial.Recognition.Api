using MediatR;
using Meeting.Management.Domain.Commands.Request;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Domain.Queries.Request;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Meeting.Management.Presentation.Api.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<ActionResult<User>> Create(CreateUserRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);  
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<User>> GetAll()
        {
            var query = new GetAllUserRequest();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
