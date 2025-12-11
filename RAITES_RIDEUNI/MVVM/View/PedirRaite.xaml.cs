using RAITES_RIDEUNI.MVVM.ViewModel;
using Ride.MVVM.Services;

namespace RAITES_RIDEUNI.MVVM.View
{
    public partial class PedirRidePage : ContentPage
    {
        private readonly MockService _service = MockService.Instance;

        public PedirRidePage()
        {
            InitializeComponent();
        }

        private async void OnBuscarClicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new ViajesDisponiblesPage
            {
                BindingContext = new ViajesDisponiblesViewModel()
            });
        }
    }
}
