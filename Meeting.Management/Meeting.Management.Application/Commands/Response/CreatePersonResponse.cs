using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Commands.Response
{
    public class CreatePersonResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Level Level { get; set; }
    }
}
