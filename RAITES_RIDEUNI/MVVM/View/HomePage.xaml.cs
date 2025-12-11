using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        // Conecta con el HomeViewModel
        BindingContext = (Application.Current.MainPage as AppShell).HomeVM;
    }

    private async void BtnVerMisRaites_Clicked(object sender, EventArgs e)
    {
        var homeVM = BindingContext as HomeViewModel;
        await Navigation.PushAsync(new MisRaites(homeVM));
    }
}
