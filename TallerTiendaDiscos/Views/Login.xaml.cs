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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void signUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Register());
        }
         
        private async void login_Clicked(object sender, EventArgs e)
        {
            string username = userName.Text;
            string pass = password.Text;
            Usuario user = await App.Database2.GetUsuariosByUserName(username);
            if (user==null) {
                await DisplayAlert("Error", "No Existe el usuario", "De Acuerdo");
            }

            else {
                if (pass.Equals(user.Password))
                {
                    await Navigation.PushModalAsync(new MainPage());
                }
                else { 
                    await DisplayAlert("Error", "La Contraseña no es correcta", "De Acuerdo");
                }
            }

            

        }
    }
}