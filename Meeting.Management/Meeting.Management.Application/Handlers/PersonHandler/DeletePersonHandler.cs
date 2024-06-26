﻿using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonRequest, Unit>
    {
        private readonly IPersonRepository _personRepository;

        public DeletePersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Unit> Handle(DeletePersonRequest request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);
            await _personRepository.DeleteAsync(person);
            return Unit.Value;
        }
    }
}
