using Meetings.Management.Domain.Enums;

namespace Meetings.Management.Domain.Entities
{
    public class Level
    {
        public Guid Id { get; set; }
        public LevelEnum Type { get; set; }
    }
}
