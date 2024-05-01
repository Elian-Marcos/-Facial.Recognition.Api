using MediatR;
using Meeting.Management.Domain.Commands.Request;
using Meeting.Management.Domain.Commands.Response;

namespace Meeting.Management.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateUserResponse());
        }
    }
}
