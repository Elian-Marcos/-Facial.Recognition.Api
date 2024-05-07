using MediatR;
using Meeting.Management.Domain.Enums;

namespace Meeting.Management.Application.Commands.Request.Person
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
