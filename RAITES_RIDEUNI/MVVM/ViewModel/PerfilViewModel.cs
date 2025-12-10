using Ride.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

    public event PropertyChangedEventHandler PropertyChanged;

    public PerfilViewModel()
    {
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

    void OnChanged([CallerMemberName] string name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

