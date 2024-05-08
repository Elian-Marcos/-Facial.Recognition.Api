using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetByIdPersonHandler : IRequestHandler<GetPersonByIdRequest, Person>
    {
        private readonly IPersonRepository _personRepository;
        public GetByIdPersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> Handle(GetPersonByIdRequest request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetById(request.Id);
            return await Task.FromResult(person);
        }
    }
}
