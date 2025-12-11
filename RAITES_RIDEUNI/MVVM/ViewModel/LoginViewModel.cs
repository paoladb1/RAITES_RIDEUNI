using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel
{
    public class LoginViewModel : BindableObject
    {
        private string correo;
        public string Correo
        {
            get => correo;
            set
            {
                correo = value;
                OnPropertyChanged();
            }
        }

        private string contraseña;
        public string Contraseña
        {
            get => contraseña;
            set
            {
                contraseña = value;
                OnPropertyChanged();
            }
        }

        public ICommand IniciarSesionCommand { get; }

        public LoginViewModel()
        {
            IniciarSesionCommand = new Command(async () => await IniciarSesion());
        }

        private async Task IniciarSesion()
        {
            if (string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(Contraseña))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Completa todos los campos.", "OK");
                return;
            }

            await Shell.Current.GoToAsync("//PaginaPrincipal");
        }
    }
}
