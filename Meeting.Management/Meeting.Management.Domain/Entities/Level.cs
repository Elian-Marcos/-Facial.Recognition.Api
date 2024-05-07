﻿using Meeting.Management.Domain.Enums;

namespace Meeting.Management.Domain.Entities
{
    public class Level
    {
        public Guid Id { get; set; }
        public LevelEnum Type { get; set; }
    }
}
