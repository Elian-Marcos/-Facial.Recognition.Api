using MediatR;
using Meeting.Management.Application.Queries.Request.Persons;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
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
