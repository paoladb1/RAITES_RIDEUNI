using Microsoft.Maui.Controls;
using RAITES_RIDEUNI.MVVM.View;
using System;

namespace Ride.MVVM.View
{
    [QueryProperty(nameof(Usuario), "usuario")]
    public partial class BienvenidaPage : ContentPage
    {
        private string usuario;
        public string Usuario
        {
            get => usuario;
            set
            {
                usuario = value;
                LblUsuario.Text = string.IsNullOrWhiteSpace(usuario)
                                  ? "Hola!"
                                  : $"Hola, {usuario}!";
            }
        }

        public BienvenidaPage()
        {
            InitializeComponent();
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync(nameof(PedirRide));
        }

        private async void BtnVerMasRaites_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ListaRaitesPage));
        }
    }

    internal class ListaRaitesPage
    {
    }
}