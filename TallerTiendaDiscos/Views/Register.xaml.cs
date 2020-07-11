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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }

        private async void signUp_Clicked(object sender, EventArgs e)
        {
            if (!string.Equals(password.Text, confirmpassword.Text))
            {
                await DisplayAlert("Error", "Las Contraseñas no coinciden", "De Acuerdo");
                password.Text = string.Empty;
                confirmpassword.Text = string.Empty;
            }
            else {
                Usuario user = await App.Database2.GetUsuariosByUserName(userName.Text);
                if (user!=null)
                {
                    await DisplayAlert("Error", "El usuario ya existe", "De Acuerdo");
                }
                else {
                    try
                    {
                        Usuario nuevo = new Usuario();
                        nuevo.UserName = userName.Text;
                        nuevo.Password = password.Text;
                        await App.Database2.SaveUsuario(nuevo);
                        await DisplayAlert("Exito", "Datos registrados en la base de datos", "De Acuerdo");
                        await Navigation.PushModalAsync(new Login());
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("Error", ex.Message, "Aceptar");
                    }
                }
               
            }
                
        }
    }
}