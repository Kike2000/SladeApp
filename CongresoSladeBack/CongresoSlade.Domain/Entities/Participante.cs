﻿using System;
using System.Collections.Generic;

namespace CongresoSlade.Domain.Entities
{
    public partial class Participante : BaseEntity
    {
        public string? Email { get; set; }
        public string? Procedencia { get; set; }
        public string? Institucion { get; set; }
        public string? Contraseña { get; set; }
    }
}