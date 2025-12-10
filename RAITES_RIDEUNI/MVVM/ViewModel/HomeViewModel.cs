using RAITES_RIDEUNI.MVVM.View;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class HomeViewModel : BindableObject
{
    public ObservableCollection<string> Rides { get; set; }
    public ObservableCollection<string> MisRaites { get; set; }

    public ICommand IrACrearRaiteCommand { get; }
    public ICommand SolicitarCommand { get; }
    public ICommand EliminarCommand { get; set; }

    public HomeViewModel()
    {
        Rides = new ObservableCollection<string>
            {
                "Sendero - UTS (7:10 AM)",
                "Mercado - ITSON (11:00 AM)",
                "Centro - ITSON (8:30 AM)"
            };

        MisRaites = new ObservableCollection<string>();

        IrACrearRaiteCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync(nameof(CrearRaitePage));
        });

        SolicitarCommand = new Command<string>(async (ride) =>
        {
            if (!string.IsNullOrEmpty(ride))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Solicitud enviada",
                    $"Tu raite '{ride}' ha sido solicitado.",
                    "Aceptar"
                );

                MisRaites.Add(ride);
            }
        });
    }
}

