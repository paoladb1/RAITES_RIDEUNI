using RAITES_RIDEUNI.MVVM.View;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class DetalleRaiteViewModel
{
    public ICommand SolicitarRaiteCommand { get; }

    public DetalleRaiteViewModel()
    {
        SolicitarRaiteCommand = new Command(async () => await SolicitarRaite());
    }

    private async Task SolicitarRaite()
    {
        await Application.Current.MainPage.DisplayAlert("Solicitud Enviada", "Tu solicitud fue enviada al conductor.", "OK");
        await Shell.Current.GoToAsync(nameof(MisRaites));
    }
}