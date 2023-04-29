using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GimnasioBarsAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void Salir_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new GimnasioLoginPage());

        }

        private async void BtnNutricion_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Nutricion());

        }

        private async void BtnEjercicios_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Ejercicios());


        }

        private async void BtnRutinas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rutinas());
        }

        private async void BtnContactanos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Contactanos());
        }
    }
}