using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class UpdateMeetingHandler : IRequestHandler<UpdateMeetingRequest, Unit>
    {
        private readonly IMeetingRepository _meetingRepository;

        public UpdateMeetingHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<Unit> Handle(UpdateMeetingRequest request, CancellationToken cancellationToken)
        {
            var meeting = await _meetingRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);

            meeting.Description = string.IsNullOrEmpty(request.Description) ? meeting.Description : request.Description;
            meeting.Date = string.IsNullOrEmpty(request.Date.ToString()) ? meeting.Date : request.Date;
            meeting.Name = string.IsNullOrEmpty(request.Name) ? meeting.Name : request.Name;

            await _meetingRepository.UpdateAsync(meeting);

            return Unit.Value;
        }
    }
}
