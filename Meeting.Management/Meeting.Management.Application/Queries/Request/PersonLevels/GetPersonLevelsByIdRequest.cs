using MediatR;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Queries.Request.Persons
{
    public class GetPersonLevelsByIdRequest : IRequest<Level>
    {
        public Guid Id { get; set; }
    }
}
