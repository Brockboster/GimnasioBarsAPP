using System;
using GimnasioBarsAPP.Services;
using GimnasioBarsAPP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GimnasioBarsAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();


            MainPage = new NavigationPage(new GimnasioLoginPage());
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
