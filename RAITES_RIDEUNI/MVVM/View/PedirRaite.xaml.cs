using Ride.MVVM.Services;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class PedirRide : ContentPage
{
    private readonly MockService _service = MockService.Instance;

    public PedirRide()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void OnBuscarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MisRaites());
    }
}
