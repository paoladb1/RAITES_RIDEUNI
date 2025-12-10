using System.Windows.Input;

namespace RAITES_RIDEUNI.MVVM.ViewModel;

public class SolicitarRaiteViewModel : BindableObject
{
    public ICommand SolicitarRaiteCommand { get; }

    public SolicitarRaiteViewModel()
    {
        SolicitarRaiteCommand = new Command(SolicitarRaite);
    }

    private void SolicitarRaite()
    {

        Application.Current.MainPage.DisplayAlert("Éxito", "Has solicitado el raite", "OK");
    }
}