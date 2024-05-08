using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Application.Commands.Response.Person;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class CreateMeetingHandler : IRequestHandler<CreateMeetingRequest, CreateMeetingResponse>
    {
        private readonly IMeetingRepository _meetingRepository;

        public CreateMeetingHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<CreateMeetingResponse> Handle(CreateMeetingRequest request, CancellationToken cancellationToken)
        {
            var meeting = new Meeting()
            {
                Name = request.Name,
                Date = request.Date,
                Description = request.Description
            };

            await _meetingRepository.CreateAsync(meeting);

            var result = new CreateMeetingResponse()
            {
                Name = request.Name,
                Date = request.Date,
                Description = request.Description
            };

            return await Task.FromResult(result);
        }

    }
}
