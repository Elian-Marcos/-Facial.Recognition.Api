using MediatR;
using Meeting.Management.Application.Commands.Response;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Commands.Request
{
    public class CreatePersonRequest : IRequest<CreatePersonResponse>
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Level Level { get; set; }
    }
}
