using RAITES_RIDEUNI.MVVM.View;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class RegistroViewModel
{
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public string Contraseña { get; set; }
    public bool IsConductor { get; set; } = true;
    public bool IsSolicitante { get; set; }

    public ICommand RegistrarCommand { get; }
    public ICommand IrALoginCommand { get; }

    public RegistroViewModel()
    {
        RegistrarCommand = new Command(async () => await Registrar());
        IrALoginCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(LoginPage)));
    }

    private async Task Registrar()
    {
        if (string.IsNullOrWhiteSpace(NombreCompleto) || string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(Contraseña))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Completa todos los campos.", "OK");
            return;
        }

        await Application.Current.MainPage.DisplayAlert("Éxito", "Cuenta creada correctamente", "OK");
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
