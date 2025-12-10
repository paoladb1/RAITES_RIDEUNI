using System;
using System.Collections.Generic;
using System.Text;

namespace RAITES_RIDEUNI.MVVM.Models
{
    internal class Raite
    {
        public int IdRaite { get; set; }
        public int IdConductor { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime HoraSalida { get; set; }
        public int LugaresDisponibles { get; set; }
        public string DescripcionAuto { get; set; }
        public Usuario Conductor { get; set; }
    }
}
