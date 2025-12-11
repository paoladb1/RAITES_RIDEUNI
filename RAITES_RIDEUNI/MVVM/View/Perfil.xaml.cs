using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class Perfil : ContentPage
{
    private PerfilViewModel viewModel;

    public Perfil()
    {
        InitializeComponent();
        viewModel = new PerfilViewModel();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.CargarDatos();
    }

    private async void EditarPerfil_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(EditarPerfilPage));
    }
}
