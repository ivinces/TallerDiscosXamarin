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
    public partial class CarritoCompras : ContentPage
    {
        public CarritoCompras()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            List<Cart> Carro= await App.Database.GetDiscos();

            this.StdList.ItemsSource = Carro;

        }

        private async void Eliminar_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var disco = button.BindingContext as Cart;

            try
            {
                await App.Database.DeleteDiscos(disco);
                await DisplayAlert("Exito", "Eliminado del Carrito", "De Acuerdo");
                await Navigation.PushAsync(new CarritoCompras());
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}