using MediatR;
using Meeting.Management.Application.Queries.Request;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
{
    public class GetAllPersonHandler : IRequestHandler<GetAllPersonRequest, IEnumerable<Person>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllPersonHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Person>> Handle(GetAllPersonRequest request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetAll();

            return await Task.FromResult(result);
        }
    }
}
