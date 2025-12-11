using RAITES_RIDEUNI.MVVM.ViewModel;
using Microsoft.Maui.Controls;

namespace RAITES_RIDEUNI.MVVM.View
{
    public partial class CrearRaitePage : ContentPage
    {
        public CrearRaiteViewModel ViewModel { get; private set; }

        public CrearRaitePage()
        {
            InitializeComponent();

            // Asignamos el BindingContext al ViewModel
            ViewModel = new CrearRaiteViewModel();
            BindingContext = ViewModel;
        }
    }
}
