using MediatR;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Queries.Request
{
    public class GetAllPersonRequest : IRequest<IEnumerable<Person>>
    {
    }
}
