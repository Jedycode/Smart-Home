using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Smart_Home_System.Data;
using SQLite;
using System.IO;

namespace Smart_Home_System
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new MainPage());
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
