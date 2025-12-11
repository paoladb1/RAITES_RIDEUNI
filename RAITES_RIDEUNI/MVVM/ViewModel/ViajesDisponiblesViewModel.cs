using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace RAITES_RIDEUNI.MVVM.ViewModel
{
    public class ViajesDisponiblesViewModel : BindableObject
    {
        public ObservableCollection<string> ListaRaites { get; set; }

        public ICommand PedirRideCommand { get; }
        public ICommand VolverInicioCommand { get; }

        [Obsolete]
        public ViajesDisponiblesViewModel()
        {
            
            ListaRaites = CrearRaiteViewModel.Raites;

            PedirRideCommand = new Command<string>(static async (ride) =>
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Viaje aceptado",
                    $"Tu viaje ha sido aceptado.\n\nDetalles:\n{ride}",
                    "OK"
                );
            });

            VolverInicioCommand = new Command(async () =>
            {
                
                await Shell.Current.GoToAsync("//HomePage");
            });
        }
    }
}
