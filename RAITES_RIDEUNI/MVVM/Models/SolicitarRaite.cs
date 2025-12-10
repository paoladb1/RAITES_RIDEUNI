using System;
using System.Collections.Generic;
using System.Text;

namespace RAITES_RIDEUNI.MVVM.Models
{
    internal class SolicitarRaite
    {
        public int IdSolicitud { get; set; }
        public int IdRaite { get; set; }
        public int IdPasajero { get; set; }
        public string Estado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public Raite Raite { get; set; }
        public Usuario Pasajero { get; set; }
    }
}
