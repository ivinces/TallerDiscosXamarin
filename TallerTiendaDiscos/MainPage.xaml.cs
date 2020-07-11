using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TallerTiendaDiscos.Views;

namespace TallerTiendaDiscos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMenu();

        }
        public void MyMenu()
        {

            Detail = new NavigationPage(new Home());
            List<Menu> menu = new List<Menu>
            {
                new Menu { Page = new Home(), MenuTitle = "Home" },
                new Menu { Page= new CarritoCompras(), MenuTitle="Carrito"},
                new Menu { Page= new Mi_Cuenta(), MenuTitle="Nuestras Tiendas"}

            };

            ListMenu.ItemsSource = menu;

        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }

        public class Menu
        {
            public string MenuTitle { get; set; }
            public Page Page { get; set; }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
