using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class MisRidesViewModel : BindableObject
{
    public ObservableCollection<string> Rides { get; }

    public ICommand EliminarCommand { get; }

    public MisRidesViewModel()
    {

        Rides = new ObservableCollection<string>
            {
                "Conductor: Carlos Mendez - 5:15 PM",
                "Conductora: Ana Lopez - 7:15 AM",
                "Conductor: Rodolfo - 1:00 PM"
            };

        EliminarCommand = new Command<string>(Eliminar);
    }

    private void Eliminar(string ride)
    {
        if (Rides.Contains(ride))
            Rides.Remove(ride);
    }
}

