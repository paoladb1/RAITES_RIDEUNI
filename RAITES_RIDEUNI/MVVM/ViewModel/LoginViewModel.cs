using RAITES_RIDEUNI.MVVM.View;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class LoginViewModel
{
    public string Correo { get; set; }
    public string Contraseña { get; set; }

    public ICommand IniciarSesionCommand { get; }
    public ICommand CrearCuentaCommand { get; }

    public LoginViewModel()
    {
        IniciarSesionCommand = new Command(async () => await IniciarSesion());
        CrearCuentaCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(RegistroPage)));
    }

    private async Task IniciarSesion()
    {
        if (string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(Contraseña))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Completa todos los campos.", "OK");
            return;
        }


        await Shell.Current.GoToAsync(nameof(PaginaPrincipal));
    }


}
