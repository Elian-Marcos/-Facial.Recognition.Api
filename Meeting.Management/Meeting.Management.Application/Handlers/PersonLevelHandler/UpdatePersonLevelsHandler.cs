using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class UpdatePersonLevelsHandler : IRequestHandler<UpdatePersonLevelsRequest, Unit>
    {
        private readonly IPersonLevelsRepository _personLevelRepository;
        public UpdatePersonLevelsHandler(IPersonLevelsRepository personLevelRepository)
        {
            _personLevelRepository = personLevelRepository;
        }

        public async Task<Unit> Handle(UpdatePersonLevelsRequest request, CancellationToken cancellationToken)
        {
            var person = await _personLevelRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);
            //fazer lógica

            await _personLevelRepository.UpdateAsync(person);

            return Unit.Value;
        }
    }
}
