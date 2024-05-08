using MediatR;
using Meetings.Management.Application.Queries.Request.Persons;
using Meetings.Management.Domain.Entities;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class GetAllMeetingHandler : IRequestHandler<GetAllMeetingRequest, IEnumerable<Meeting>>
    {
        private readonly IMeetingRepository _meetingRepository;

        public GetAllMeetingHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<IEnumerable<Meeting>> Handle(GetAllMeetingRequest request, CancellationToken cancellationToken)
        {
            var result = await _meetingRepository.GetAll();

            return await Task.FromResult(result);
        }
    }
}
