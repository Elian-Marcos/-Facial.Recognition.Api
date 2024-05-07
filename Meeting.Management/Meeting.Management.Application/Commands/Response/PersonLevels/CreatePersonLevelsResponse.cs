using Meeting.Management.Domain.Enums;

namespace Meeting.Management.Application.Commands.Response.Person
{
    public class CreatePersonLevelsResponse
    {
        public Guid Id { get; set; }
        public LevelEnum Type { get; set; }
       
    }
}
