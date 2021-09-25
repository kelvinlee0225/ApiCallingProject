using ApiCallingProject.Services;
using ApiCallingProject.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiCallingProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimeSongPage();
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
