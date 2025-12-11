using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class EditarPerfilPage : ContentPage
{
    private PerfilViewModel viewModel;

    public EditarPerfilPage()
    {
        InitializeComponent();
        viewModel = new PerfilViewModel();
        BindingContext = viewModel;
    }
}
