using MediatR;
using Meeting.Management.Application.Queries.Request.Persons;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
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
