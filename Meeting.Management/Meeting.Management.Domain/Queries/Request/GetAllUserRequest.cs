using MediatR;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Domain.Queries.Request
{
    public class GetAllUserRequest : IRequest<IEnumerable<User>>
    {
    }
}
