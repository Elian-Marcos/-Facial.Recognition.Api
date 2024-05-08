using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetAllPersonLevelsHandler : IRequestHandler<GetAllPersonLevelsRequest, IEnumerable<Level>>
    {
        private readonly IPersonLevelsRepository _personLevelsRepository;

        public GetAllPersonLevelsHandler(IPersonLevelsRepository personLevelsRepository)
        {
            _personLevelsRepository = personLevelsRepository;
        }

        public async Task<IEnumerable<Level>> Handle(GetAllPersonLevelsRequest request, CancellationToken cancellationToken)
        {
            var result = await _personLevelsRepository.GetAll();

            return await Task.FromResult(result);
        }
    }
}
