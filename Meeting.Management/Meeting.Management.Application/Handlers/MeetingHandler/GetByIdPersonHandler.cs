using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetByIdMeetingHandler : IRequestHandler<GetMeetingByIdRequest, Meeting>
    {
        private readonly IMeetingRepository _meetingRepository;

        public GetByIdMeetingHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<Meeting> Handle(GetMeetingByIdRequest request, CancellationToken cancellationToken)
        {
            var meeting = await _meetingRepository.GetById(request.Id);
            return await Task.FromResult(meeting);
        }
    }
}
