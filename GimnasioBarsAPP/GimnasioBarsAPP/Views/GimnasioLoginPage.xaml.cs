using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GimnasioBarsAPP.ViewModels;
using Acr.UserDialogs;

namespace GimnasioBarsAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GimnasioLoginPage : ContentPage
    {

        UserViewModel viewModel;


        public GimnasioLoginPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new UserViewModel();



        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());


        }
            
                //si hay datos en el usuario y contraseña se puede continuar 
               

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            //Registro
            await Navigation.PushAsync(new Registro());


        }
    }
}