using MediatR;
using Meeting.Management.Application.Queries.Request.Persons;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
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
