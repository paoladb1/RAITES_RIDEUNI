using System;
using System.Collections.Generic;
using System.Text;

namespace RAITES_RIDEUNI.MVVM.Models
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string TipoUsuario { get; set; }
        public string FotoPerfil { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
