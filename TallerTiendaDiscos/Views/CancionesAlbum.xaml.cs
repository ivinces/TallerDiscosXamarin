using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerTiendaDiscos.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerTiendaDiscos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CancionesAlbum : ContentPage
    {
        Discos Escogido;
        public CancionesAlbum(Discos Disco)
        {
            InitializeComponent();

            Escogido = Disco;

            lsCanciones.ItemsSource = Disco.Canciones;

            AlbumFoto.Source = Disco.ImagenUrlDiscos;
            AlbumText.Text = Disco.Nombre;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Cart Carro = new Cart();

            Carro.Nombre = Escogido.Nombre;
            Carro.ImagenURL = Escogido.ImagenUrlDiscos;
            try
            {
                var stdnew = Carro;
                await App.Database.SaveDiscos(stdnew);
                await DisplayAlert("Exito", "Disco Agregado al Carrito", "De Acuerdo");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}