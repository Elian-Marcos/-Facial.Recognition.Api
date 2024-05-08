using MediatR;
using Meetings.Management.Application.Commands.Request.Person;
using Meetings.Management.Infrastructure.Interface;

namespace Meetings.Management.Application.Handlers.PersonHandler
{
    public class DeleteMeetingHandler : IRequestHandler<DeleteMeetingRequest, Unit>
    {
        private readonly IMeetingRepository _meetingRepository;

        public DeleteMeetingHandler(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        public async Task<Unit> Handle(DeleteMeetingRequest request, CancellationToken cancellationToken)
        {
            var person = await _meetingRepository.GetById(request.Id) ?? throw new Exception("Not Found: " + request.Id);
            await _meetingRepository.DeleteAsync(person);
            return Unit.Value;
        }
    }
}
