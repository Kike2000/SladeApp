﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongresoSlade.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        //public string? Password { get; set; }
        //public string? Role { get; set; }
    }
}
