using Meetings.Management.Domain.Enums;

namespace Meetings.Management.Application.Commands.Response.Person
{
    public class CreatePersonLevelsResponse
    {
        public Guid Id { get; set; }
        public LevelEnum Type { get; set; }
       
    }
}
