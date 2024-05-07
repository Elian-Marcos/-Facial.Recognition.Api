using MediatR;
using Meeting.Management.Domain.Entities;

namespace Meeting.Management.Application.Queries.Request.Persons
{
    public class GetPersonByIdRequest : IRequest<Person>
    {
        public Guid Id { get; set; }
    }
}
