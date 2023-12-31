﻿using System;
using System.Collections.Generic;

namespace CongresoSlade.Domain.Entities
{
    public partial class Registro : BaseEntity
    {
        public Guid ParticipanteId { get; set; }
        public Guid EventoId { get; set; }
        public DateTime? HoraDeRegistro { get; set; }
        public bool Asistencia { get; set; }
    }
}
