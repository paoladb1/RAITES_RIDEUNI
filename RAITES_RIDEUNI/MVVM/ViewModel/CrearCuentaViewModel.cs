using RAITES_RIDEUNI.MVVM.View;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel
{
    public class CrearCuentaViewModel : BindableObject
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand CrearCuentaCommand { get; }

        public CrearCuentaViewModel()
        {
            CrearCuentaCommand = new Command(async () => await CrearCuenta());
        }

        private async Task CrearCuenta()
        {
            if (string.IsNullOrWhiteSpace(Nombre) ||
                string.IsNullOrWhiteSpace(Correo) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor llena todos los campos.", "OK");
                return;
            }

            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Éxito", "Cuenta creada correctamente.", "OK");

            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
    }
}
