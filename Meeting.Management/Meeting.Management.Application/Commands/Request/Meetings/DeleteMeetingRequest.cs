using MediatR;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class DeleteMeetingRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
