﻿namespace CongresoServer.Model
{
    public class Participante
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Procedencia { get; set; }
        public string Institucion { get; set; }
        public string Contraseña { get; set; }

    }
}
