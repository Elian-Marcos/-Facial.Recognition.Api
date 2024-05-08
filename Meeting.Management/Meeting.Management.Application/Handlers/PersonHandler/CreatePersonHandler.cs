using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Commands.Response.Person;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonRequest, CreatePersonResponse>
    {
        private readonly IPersonRepository _userRepository;

        public CreatePersonHandler(IPersonRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreatePersonResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
        {
            var person = new Person()
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                Level = request.Level,
                Photo = request.Photo
            };

            await _userRepository.CreateAsync(person);

            var result = new CreatePersonResponse()
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                Level = request.Level,
                Photo = request.Photo
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
