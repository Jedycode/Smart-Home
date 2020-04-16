using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Smart_Home_System.Views;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public string GetCurrentTime()
        {
            String myDate = DateTime.Now.ToString();
            return myDate;
        }
        private void Devices_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceManagmentPage());
        }

        private void Scripts_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScriptsPage());
        }

        private void HouseMap_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HouseMapPage());
        }

        private void OnHouseSecurityTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecurityPage());
        }

        private void OnLightsTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LightsPage());
        }

        private void OnTemperatureTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TemperatureMenuPage());
        }

        private void OnHouseLouversTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LouversMenuPage());
        }
    }
}
