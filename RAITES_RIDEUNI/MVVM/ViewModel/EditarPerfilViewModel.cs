using Ride.Services;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class EditarPerfilViewModel : BindableObject
{
    public string Nombre { get; set; }
    public string Rol { get; set; }
    public string Universidad { get; set; }
    public string Grupo { get; set; }
    public string Disponible { get; set; }
    public string Descripcion { get; set; }

    public ICommand GuardarCommand { get; }

    public EditarPerfilViewModel()
    {
        Nombre = PerfilService.Nombre;
        Rol = PerfilService.Rol;
        Universidad = PerfilService.Universidad;
        Grupo = PerfilService.Grupo;
        Disponible = PerfilService.Disponible;
        Descripcion = PerfilService.Descripcion;

        GuardarCommand = new Command(Guardar);
    }

    private async void Guardar()
    {
        PerfilService.Nombre = Nombre;
        PerfilService.Rol = Rol;
        PerfilService.Universidad = Universidad;
        PerfilService.Grupo = Grupo;
        PerfilService.Disponible = Disponible;
        PerfilService.Descripcion = Descripcion;

        await Application.Current.MainPage.DisplayAlert(
            "Perfil",
            "Datos guardados correctamente",
            "OK"
        );

        await Shell.Current.Navigation.PopAsync();
    }
}