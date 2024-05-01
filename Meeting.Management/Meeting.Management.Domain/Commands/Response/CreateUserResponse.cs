using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Domain.Commands.Response
{
    public class CreateUserResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public Level Level { get; set; }
    }
}
