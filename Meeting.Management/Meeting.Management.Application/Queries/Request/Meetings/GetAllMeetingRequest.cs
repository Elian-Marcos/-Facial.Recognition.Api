using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetAllMeetingRequest : IRequest<IEnumerable<Meeting>>
    {
    }
}
