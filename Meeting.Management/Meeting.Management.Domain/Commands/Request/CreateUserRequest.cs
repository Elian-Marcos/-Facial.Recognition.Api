using MediatR;
using Meeting.Management.Domain.Commands.Response;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Domain.Commands.Request
{
    public class CreateUserRequest : IRequest<CreateUserResponse>
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Level Level { get; set; }
    }
}
