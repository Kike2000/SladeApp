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
        public string? Nombre { get; set; }
    }
}