using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Smart_Home_System.Data;
using Smart_Home_System;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceManagmentPage : ContentPage
    {
        public DeviceManagmentPage()
        {
            InitializeComponent();
        }
                

        private async void OnDeviceTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Smart_Home_System.Model.DeviceManager.Device;
            await Navigation.PushAsync(new DeviceDetailPage(details.Name, details.DeviceType, details.PowerOn));
        }
    }
}