﻿using MediatR;
using Meetings.Management.Domain.Entities;

namespace Meetings.Management.Application.Queries.Request.Persons
{
    public class GetPersonLevelsByIdRequest : IRequest<Level>
    {
        public Guid Id { get; set; }
    }
}
