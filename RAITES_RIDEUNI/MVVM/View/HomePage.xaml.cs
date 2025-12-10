using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;


public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomeViewModel();
    }

    private async void BtnVerMisRaites_Clicked(object sender, EventArgs e)
    {
        var homeVM = this.BindingContext as HomeViewModel;
        await Navigation.PushAsync(new SolicitarRaitePage(homeVM));
    }
}



