using MediatR;
using Meeting.Management.Application.Commands.Request;
using Meeting.Management.Application.Commands.Response;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonRequest, CreatePersonResponse>
    {
        private readonly IUserRepository _userRepository;

        public CreatePersonHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreatePersonResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
        {
            var person = new Person()
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                Level = request.Level
            };

            await _userRepository.CreateAsync(person);

            var result = new CreatePersonResponse()
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                Level = request.Level
            };

            return await Task.FromResult(result);
        }

        private string HashPassword(string password)
        {
            //fazer lógica
            return password;
        }
    }
}
