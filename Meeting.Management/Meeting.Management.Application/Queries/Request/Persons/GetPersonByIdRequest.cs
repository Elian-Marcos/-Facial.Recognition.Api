using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetPersonByIdRequest : IRequest<Person>
    {
        public Guid Id { get; set; }
    }
}
