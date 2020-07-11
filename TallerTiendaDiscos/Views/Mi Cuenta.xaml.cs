using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace TallerTiendaDiscos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mi_Cuenta : TabbedPage
    {
        public Mi_Cuenta()
        {
            InitializeComponent();
            MostrarMapa(-2.155538, -79.8910639);
        }

        private void MostrarMapa(double Latitud, double Longitud)
        {
            base.OnAppearing();

            MapaGeo.MoveToRegion(
                MapSpan.FromCenterAndRadius
                (
                  new Position(Latitud, Longitud),
                  Distance.FromKilometers(0.5)
                 )
                );

            var pos = new Position(Latitud, Longitud);

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = pos,
                Label = "Curso de XAMRIN SIPECOM"
            };

            this.MapaGeo.Pins.Add(pin);
        }
    }
}