using MediatR;

namespace Meetings.Management.Application.Commands.Request.Person
{
    public class DeletePersonRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
