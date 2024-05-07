using MediatR;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Queries.Request.Persons
{
    public class GetAllPersonLevelsRequest : IRequest<IEnumerable<Level>>
    {
    }
}
