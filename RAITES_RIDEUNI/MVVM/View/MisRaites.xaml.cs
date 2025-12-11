using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View
{
    public partial class MisRaites : ContentPage
    {
        private HomeViewModel? homeVM;

        public MisRaites()
        {
            InitializeComponent();
            BindingContext = new MisRidesViewModel();
        }

        public MisRaites(HomeViewModel? homeVM)
        {
            this.homeVM = homeVM;
        }
    }
}
