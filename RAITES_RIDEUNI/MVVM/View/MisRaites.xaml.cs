using RAITES_RIDEUNI.MVVM.ViewModel;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class MisRaites : ContentPage
{
	public MisRaites()
	{
		InitializeComponent();
        BindingContext = new MisRaitesViewModel();
    }
}