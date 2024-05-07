using MediatR;
using Meeting.Management.Application.Commands.Request.Person;
using Meeting.Management.Application.Commands.Response.Person;
using Meeting.Management.Domain.Entities;
using Meeting.Management.Infrastructure.Interface;

namespace Meeting.Management.Application.Handlers.PersonHandler
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
