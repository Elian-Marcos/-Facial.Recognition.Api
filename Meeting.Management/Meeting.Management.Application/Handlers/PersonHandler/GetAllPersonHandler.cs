using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetAllPersonHandler : IRequestHandler<GetAllPersonRequest, IEnumerable<Person>>
    {
        private readonly IPersonRepository _personRepository;

        public GetAllPersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> Handle(GetAllPersonRequest request, CancellationToken cancellationToken)
        {
            var result = await _personRepository.GetAll();

            return await Task.FromResult(result);
        }
    }
}
