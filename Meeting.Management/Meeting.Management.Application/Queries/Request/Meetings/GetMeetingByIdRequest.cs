using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetMeetingByIdRequest : IRequest<Meeting>
    {
        public Guid Id { get; set; }
    }
}
