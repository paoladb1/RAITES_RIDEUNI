using RAITES_RIDEUNI.MVVM.ViewModel;
using Microsoft.Maui.Controls;

namespace RAITES_RIDEUNI.MVVM.View
{
    public partial class ViajesDisponiblesPage : ContentPage
    {
        public ViajesDisponiblesViewModel ViewModel { get; private set; }

        public ViajesDisponiblesPage()
        {
            InitializeComponent();

            // Asignamos el BindingContext
            ViewModel = new ViajesDisponiblesViewModel();
            BindingContext = ViewModel;
        }
    }
}
