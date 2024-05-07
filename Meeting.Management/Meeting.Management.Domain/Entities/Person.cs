﻿using Meeting.Management.Domain.Enums;

namespace Meeting.Management.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public LevelEnum Level { get; set; }
        public byte[] Photo { get; set; }
    }
}
