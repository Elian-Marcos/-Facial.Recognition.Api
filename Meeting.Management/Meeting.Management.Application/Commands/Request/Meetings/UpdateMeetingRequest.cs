using MediatR;
using Meetings.Management.Domain.Enums;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class UpdateMeetingRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
