namespace RAITES_RIDEUNI.MVVM.View;

public partial class Mensajes : ContentPage
{
    public Mensajes()
    {
        InitializeComponent();
        BindingContext = new RAITES_RIDEUNI.MVVM.ViewModel.MensajesViewModel();
    }
}
