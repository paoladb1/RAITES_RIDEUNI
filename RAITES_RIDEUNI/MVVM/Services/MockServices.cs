using System.Collections.ObjectModel;

namespace Ride.MVVM.Services
{
    public class Raite
    {
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
    }


    public sealed class MockService
    {
        private static MockService? _instance;
        public static MockService Instance => _instance ??= new MockService();

        public ObservableCollection<Raite> RaitesDisponibles { get; }
        public ObservableCollection<Raite> MisRaites { get; }

        private MockService()
        {
            RaitesDisponibles = new ObservableCollection<Raite>()
            {
                new Raite { Origen="Sendero", Destino="UTS", Hora="7:10 AM" },
                new Raite { Origen="Pueblo Yaqui", Destino="UTS", Hora="6:50 AM" },
                new Raite { Origen="Valle Dorado", Destino="UTS", Hora="8:00 AM" },
                new Raite { Origen="Centro", Destino="ITSON", Hora="7:45 AM" }
            };

            MisRaites = new ObservableCollection<Raite>();
        }
    }
}