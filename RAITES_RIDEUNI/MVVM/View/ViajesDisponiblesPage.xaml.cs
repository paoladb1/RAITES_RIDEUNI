using RAITES_RIDEUNI.MVVM.ViewModel;
using Microsoft.Maui.Controls;

namespace RAITES_RIDEUNI.MVVM.View
{
    public partial class ViajesDisponiblesPage : ContentPage
    {
        public ViajesDisponiblesViewModel ViewModel { get; private set; }

        [Obsolete]
        public ViajesDisponiblesPage()
        {
            InitializeComponent();

           
            ViewModel = new ViajesDisponiblesViewModel();
            BindingContext = ViewModel;
        }
    }
}
