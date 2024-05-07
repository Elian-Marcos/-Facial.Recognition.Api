﻿using MediatR;
using Meeting.Management.Application.Commands.Response.Person;
using Meeting.Management.Domain.Enums;

namespace Meeting.Management.Application.Commands.Request.Person
{
    public class CreatePersonLevelsRequest : IRequest<CreatePersonLevelsResponse>
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public LevelEnum Level { get; set; }
        public byte[] Photo { get; set; }
    }
}