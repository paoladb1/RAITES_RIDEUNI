using Ride.MVVM.Services;

namespace RAITES_RIDEUNI.MVVM.View;

public partial class LoginPage : ContentPage
{
    MockService _service = MockService.Instance;

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntryEmail.Text) ||
            string.IsNullOrWhiteSpace(EntryPassword.Text))
        {
            await DisplayAlert("Error", "Ingresa tu correo y contraseña", "OK");
            return;
        }


    }
}