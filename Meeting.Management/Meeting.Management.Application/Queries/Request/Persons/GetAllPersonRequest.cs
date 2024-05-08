using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetAllPersonRequest : IRequest<IEnumerable<Person>>
    {
    }
}
