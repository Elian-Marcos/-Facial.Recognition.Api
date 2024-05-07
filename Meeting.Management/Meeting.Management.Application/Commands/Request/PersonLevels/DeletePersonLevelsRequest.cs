using MediatR;

namespace Meeting.Management.Application.Commands.Request.Person
{
    public class DeletePersonLevelsRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
