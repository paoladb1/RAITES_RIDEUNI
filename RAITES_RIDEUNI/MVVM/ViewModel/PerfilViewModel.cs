using RAITES_RIDEUNI.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class PerfilViewModel : INotifyPropertyChanged
{
    private string _nombre;
    private string _rol;
    private string _universidad;
    private string _grupo;
    private string _disponible;
    private string _descripcion;

    public string Nombre { get => _nombre; set { _nombre = value; OnChanged(); } }
    public string Rol { get => _rol; set { _rol = value; OnChanged(); } }
    public string Universidad { get => _universidad; set { _universidad = value; OnChanged(); } }
    public string Grupo { get => _grupo; set { _grupo = value; OnChanged(); } }
    public string Disponible { get => _disponible; set { _disponible = value; OnChanged(); } }
    public string Descripcion { get => _descripcion; set { _descripcion = value; OnChanged(); } }

    public ICommand GuardarCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    public PerfilViewModel()
    {
        GuardarCommand = new Command(GuardarDatos);
        CargarDatos();
    }

    public void CargarDatos()
    {
        Nombre = PerfilService.Nombre;
        Rol = PerfilService.Rol;
        Universidad = PerfilService.Universidad;
        Grupo = PerfilService.Grupo;
        Disponible = PerfilService.Disponible;
        Descripcion = PerfilService.Descripcion;
    }

    private void GuardarDatos()
    {
        PerfilService.Nombre = Nombre;
        PerfilService.Rol = Rol;
        PerfilService.Universidad = Universidad;
        PerfilService.Grupo = Grupo;
        PerfilService.Disponible = Disponible;
        PerfilService.Descripcion = Descripcion;

        Application.Current.MainPage.DisplayAlert("Éxito", "Datos guardados correctamente", "OK");
        Shell.Current.GoToAsync(".."); // Regresa a Perfil
    }

    void OnChanged([CallerMemberName] string name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
