﻿
using System;

namespace Optimization.Common.Models.Dto
{
    public class ProjectDto
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
