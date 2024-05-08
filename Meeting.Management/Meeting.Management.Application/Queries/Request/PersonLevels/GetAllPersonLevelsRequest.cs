using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetAllPersonLevelsRequest : IRequest<IEnumerable<Level>>
    {
    }
}
