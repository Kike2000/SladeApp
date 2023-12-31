﻿namespace CongresoSlade.Application.DTOs.Response.EventoResponse
{
    public class EventoSelectResponseDTO
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraTermino { get; set; }
        public Guid? AreaId { get; set; }
        public bool AgendaAbierta { get; set; } = true;
    }
}
