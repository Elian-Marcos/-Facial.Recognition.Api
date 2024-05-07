﻿using MediatR;
using Meeting.Management.Application.Queries.Request.Persons;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
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
