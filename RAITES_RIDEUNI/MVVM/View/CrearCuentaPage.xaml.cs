namespace RAITES_RIDEUNI.MVVM.View;

public partial class CrearCuentaPage : ContentPage
{
	public CrearCuentaPage()
	{
		InitializeComponent();
	}
    private async void OnCrearCuentaClicked(object sender, EventArgs e)
    {
        string nombre = EntryNombre.Text;
        string email = EntryEmail.Text;
        string password = EntryPassword.Text;
        string confirmPassword = EntryConfirmPassword.Text;

        if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Error", "Por favor llena todos los campos.", "OK");
            return;
        }

        if (password != confirmPassword)
        {
            await DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
            return;
        }

        await DisplayAlert("Éxito", "Cuenta creada correctamente.", "OK");


        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}