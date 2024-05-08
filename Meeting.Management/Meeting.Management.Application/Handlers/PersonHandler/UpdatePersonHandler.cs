using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonRequest, Unit>
    {
        private readonly IPersonRepository _userRepository;
        public UpdatePersonHandler(IPersonRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdatePersonRequest request, CancellationToken cancellationToken)
        {
            var person = await _userRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);

            person.Level = string.IsNullOrEmpty(request.Level.ToString()) ? person.Level : request.Level;
            person.Photo = string.IsNullOrEmpty(request.Photo.ToString()) ? person.Photo : request.Photo;
            person.PasswordHash = string.IsNullOrEmpty(request.PasswordHash.ToString()) ? person.PasswordHash : request.PasswordHash;

            await _userRepository.UpdateAsync(person);

            return Unit.Value;
        }
    }
}
