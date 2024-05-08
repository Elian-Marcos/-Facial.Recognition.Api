using MediatR;
using Meetings.Management.Application.Commands.Response.Person;
using Meetings.Management.Domain.Enums;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class CreatePersonRequest : IRequest<CreatePersonResponse>
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public LevelEnum Level { get; set; }
        public byte[] Photo { get; set; }
    }
}
