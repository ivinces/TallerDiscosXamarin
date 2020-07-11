using System;
using TallerTiendaDiscos.Data;
using TallerTiendaDiscos.Interface;
using TallerTiendaDiscos.Model;
using TallerTiendaDiscos.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerTiendaDiscos
{
    public partial class App : Application
    {
        public static TodoArtistaManager TodoManager { get; set; }
        static CarritoComprasDB database;
        static UsuarioDB database2;

        public static CarritoComprasDB Database
        {
            get
            {

                if (database == null)
                {
                    database = new CarritoComprasDB(DependencyService.Get<IStdLocHelper>().GetLocalFilePath("tiendadb.db"));
                }

                return database;
            }
        }
        public static UsuarioDB Database2
        {
            get
            {

                if (database2 == null)
                {
                    database2 = new UsuarioDB(DependencyService.Get<IStdLocHelper>().GetLocalFilePath("tiendadb.db"));
                }

                return database2;
            }
        }
        public App()
        {
            InitializeComponent();

            TodoManager = new TodoArtistaManager(new RestServices());


            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
