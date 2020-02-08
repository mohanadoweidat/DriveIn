using DriveIn.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Startsidan());
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