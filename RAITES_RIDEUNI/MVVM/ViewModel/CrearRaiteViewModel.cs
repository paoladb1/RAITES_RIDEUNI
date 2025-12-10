using Microsoft.Maui.Controls;
using RAITES_RIDEUNI.MVVM.View;

using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ride.MVVM.ViewModel
{
    public class CrearRaiteViewModel : BindableObject
    {

        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; } = DateTime.Now;
        public TimeSpan HoraSalida { get; set; } = DateTime.Now.TimeOfDay;
        public int AsientosDisponibles { get; set; }
        public decimal PrecioPorAsiento { get; set; }


        public static ObservableCollection<string> Raites { get; set; } = new ObservableCollection<string>();


        public ICommand PublicarCommand { get; }

        public CrearRaiteViewModel()
        {
            PublicarCommand = new Command(async () => await PublicarRaite());
        }

        private async Task PublicarRaite()
        {

            if (string.IsNullOrWhiteSpace(Origen) || string.IsNullOrWhiteSpace(Destino) ||
                AsientosDisponibles <= 0 || PrecioPorAsiento <= 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "Por favor completa todos los campos correctamente.", "OK");
                return;
            }

            string raite = $"{Origen} - {Destino}    {FechaSalida:dd/MM/yyyy} {HoraSalida:hh\\:mm}  Asientos: {AsientosDisponibles}    ${PrecioPorAsiento}";
            Raites.Add(raite);

            await Application.Current.MainPage.DisplayAlert("Éxito", "Raite publicado correctamente.", "OK");


            Origen = Destino = "";
            AsientosDisponibles = 0;
            PrecioPorAsiento = 0;
            FechaSalida = DateTime.Now;
            HoraSalida = DateTime.Now.TimeOfDay;

            OnPropertyChanged(nameof(Origen));
            OnPropertyChanged(nameof(Destino));
            OnPropertyChanged(nameof(FechaSalida));
            OnPropertyChanged(nameof(HoraSalida));
            OnPropertyChanged(nameof(AsientosDisponibles));
            OnPropertyChanged(nameof(PrecioPorAsiento));


            await Shell.Current.GoToAsync(nameof(ViajesDisponiblesPage));
        }
    }  }