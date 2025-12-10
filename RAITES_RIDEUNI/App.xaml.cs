using Microsoft.Extensions.DependencyInjection;

namespace RAITES_RIDEUNI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new AppShell();
        }
    }
}