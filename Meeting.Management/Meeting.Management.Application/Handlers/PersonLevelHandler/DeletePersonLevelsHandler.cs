using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class DeletePersonLevelsHandler : IRequestHandler<DeletePersonLevelsRequest, Unit>
    {
        private readonly IPersonLevelsRepository _personLevelsRepository;

        public DeletePersonLevelsHandler(IPersonLevelsRepository personLevelsRepository)
        {
            _personLevelsRepository = personLevelsRepository;
        }

        public async Task<Unit> Handle(DeletePersonLevelsRequest request, CancellationToken cancellationToken)
        {
            var person = await _personLevelsRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);
            await _personLevelsRepository.DeleteAsync(person);
            return Unit.Value;
        }
    }
}
