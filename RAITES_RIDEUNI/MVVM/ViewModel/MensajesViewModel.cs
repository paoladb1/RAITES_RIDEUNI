using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class MensajeItem
{
    public string Texto { get; set; }
}

public class MensajesViewModel : BindableObject
{
    public ObservableCollection<MensajeItem> Mensajes { get; set; }
    public string MensajeNuevo { get; set; }

    public ICommand EnviarCommand { get; }
    public ICommand EliminarCommand { get; }

    [Obsolete]
    public MensajesViewModel()
    {
        Mensajes = new ObservableCollection<MensajeItem>();

      
        EnviarCommand = new Command(() =>
        {
            if (!string.IsNullOrWhiteSpace(MensajeNuevo))
            {
                Mensajes.Add(new MensajeItem { Texto = MensajeNuevo });
                MensajeNuevo = string.Empty;
                OnPropertyChanged(nameof(MensajeNuevo));
            }
        });

        
        EliminarCommand = new Command<MensajeItem>(async (msg) =>
        {
            if (msg == null) return;

            bool confirmar = await Application.Current.MainPage.DisplayAlert(
                "Eliminar mensaje",
                "¿Deseas eliminar este mensaje?",
                "Sí", "No");

            if (confirmar)
            {
                Mensajes.Remove(msg);
            }
        });
    }
}
