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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            this.CLRock.ItemsSource= await App.TodoManager.GetRockItem();
            this.CLPop.ItemsSource = await App.TodoManager.GetPopItem();
        }

        private async void CLPop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Discos Escogido;

            if (e.CurrentSelection.Any())
            {

                Escogido = (CLPop.SelectedItem as Discos);
                await Navigation.PushAsync(new CancionesAlbum(Escogido)
                {
                    BindingContext = e.CurrentSelection

                });

            }
        }

        private async void CLRock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Discos Escogido;

            if (e.CurrentSelection.Any())
            {

                Escogido = (CLRock.SelectedItem as Discos);
                await Navigation.PushAsync(new CancionesAlbum(Escogido)
                {
                    BindingContext = e.CurrentSelection

                });
            }

            
           


            
        }
    }
}