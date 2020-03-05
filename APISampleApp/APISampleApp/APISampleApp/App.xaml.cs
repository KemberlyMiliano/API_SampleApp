using APISampleApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APISampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GetRandomBeerPage());
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
