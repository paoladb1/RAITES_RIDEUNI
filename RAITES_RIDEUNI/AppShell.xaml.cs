using RAITES_RIDEUNI.MVVM.View;
using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI;

public partial class AppShell : Shell
{
    public HomeViewModel HomeVM { get; private set; } = new HomeViewModel();

    public AppShell()
    {
        InitializeComponent();

        
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(CrearCuentaPage), typeof(CrearCuentaPage));

        Routing.RegisterRoute(nameof(PaginaPrincipal), typeof(PaginaPrincipal));
        Routing.RegisterRoute(nameof(PedirRidePage), typeof(PedirRidePage));
        Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));
        Routing.RegisterRoute(nameof(MisRaites), typeof(MisRaites));
        Routing.RegisterRoute(nameof(Mensajes), typeof(Mensajes));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(CrearRaitePage), typeof(CrearRaitePage));
        Routing.RegisterRoute(nameof(DetalleRaitePage), typeof(DetalleRaitePage));
        Routing.RegisterRoute(nameof(SolicitarRaitePage), typeof(SolicitarRaitePage));
        Routing.RegisterRoute(nameof(ViajesDisponiblesPage), typeof(ViajesDisponiblesPage));
        Routing.RegisterRoute(nameof(EditarPerfilPage), typeof(EditarPerfilPage));
    }
}
