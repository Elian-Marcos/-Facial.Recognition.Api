using MediatR;
using Meetings.Management.Application.Commands.Response.Person;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class CreateMeetingRequest : IRequest<CreateMeetingResponse>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
