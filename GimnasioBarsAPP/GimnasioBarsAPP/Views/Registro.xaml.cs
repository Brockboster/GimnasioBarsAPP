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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private async void BtnSalir_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new GimnasioLoginPage());



        }

        private async void BtnAcceder_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Menu());


        }
    }
}