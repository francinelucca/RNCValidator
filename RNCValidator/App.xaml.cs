using System;
using RNCValidator.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RNCValidator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RNCValidatorPage();
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
