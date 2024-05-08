using MediatR;
using Meetings.Management.Domain.Enums;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class UpdatePersonRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public LevelEnum Level { get; set; }
        public byte[] Photo { get; set; }
    }
}
