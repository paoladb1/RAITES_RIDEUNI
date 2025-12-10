using Ride.MVVM.ViewModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class ViajesDisponiblesViewModel : BindableObject
{
    public ObservableCollection<string> ListaRaites { get; set; }

    public ICommand PedirRideCommand { get; }

    public ViajesDisponiblesViewModel()
    {
        ListaRaites = CrearRaiteViewModel.Raites;

        PedirRideCommand = new Command<string>(async (ride) =>
        {
            await Application.Current.MainPage.DisplayAlert(
                "Viaje aceptado",
                $"Tu viaje ha sido aceptado.\n\nDetalles:\n{ride}",
                "OK"
            );
        });
    }
}