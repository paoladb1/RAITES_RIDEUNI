using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class SolicitarRaitePage : ContentPage
{
    public HomeViewModel HomeVM { get; private set; }


    public SolicitarRaitePage()
    {
        InitializeComponent();
    }


    public SolicitarRaitePage(HomeViewModel homeVM)
    {
        InitializeComponent();

        HomeVM = homeVM;

        BindingContext = HomeVM;


        HomeVM.EliminarCommand ??= new Command<string>(EliminarRide);
    }

    private void EliminarRide(string ride)
    {
        if (HomeVM.MisRaites.Contains(ride))
            HomeVM.MisRaites.Remove(ride);
    }
}