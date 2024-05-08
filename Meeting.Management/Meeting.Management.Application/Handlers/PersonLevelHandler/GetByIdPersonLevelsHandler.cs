using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetByIdPersonLevelsHandler : IRequestHandler<GetPersonLevelsByIdRequest, Level>
    {
        private readonly IPersonLevelsRepository _personLevelsRepository;

        public GetByIdPersonLevelsHandler(IPersonLevelsRepository personLevelsRepository)
        {
            _personLevelsRepository = personLevelsRepository;
        }

        public async Task<Level> Handle(GetPersonLevelsByIdRequest request, CancellationToken cancellationToken)
        {
            var person = await _personLevelsRepository.GetById(request.Id);
            return await Task.FromResult(person);
        }
    }
}
