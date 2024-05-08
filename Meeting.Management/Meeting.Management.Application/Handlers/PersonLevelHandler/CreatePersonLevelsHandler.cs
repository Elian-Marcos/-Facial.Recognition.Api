using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Commands.Response.Person;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class CreatePersonLevelsHandler : IRequestHandler<CreatePersonLevelsRequest, CreatePersonLevelsResponse>
    {
        private readonly IPersonLevelsRepository _personLevelsRepository;

        public CreatePersonLevelsHandler(IPersonLevelsRepository personLevelsRepository)
        {
            _personLevelsRepository = personLevelsRepository;
        }

        public async Task<CreatePersonLevelsResponse> Handle(CreatePersonLevelsRequest request, CancellationToken cancellationToken)
        {
            var level = new Level()
            {
                Type = request.Level
            };

            await _personLevelsRepository.CreateAsync(level);

            var result = new CreatePersonLevelsResponse()
            {
                Type = request.Level
            };

            return await Task.FromResult(result);
        }
    }
}
