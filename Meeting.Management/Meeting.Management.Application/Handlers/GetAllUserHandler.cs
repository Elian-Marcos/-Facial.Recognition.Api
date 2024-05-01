using MediatR;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Domain.Queries.Request;

namespace Meeting.Management.Application.Handlers
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, IEnumerable<User>>
    {
        public GetAllUserHandler() { }

        public async Task<IEnumerable<User>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {


            return (IEnumerable<User>)Task.FromResult(new List<User>());
        }
    }
}
