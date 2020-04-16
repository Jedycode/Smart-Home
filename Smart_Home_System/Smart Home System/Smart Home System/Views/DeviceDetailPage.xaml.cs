using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Smart_Home_System.Views;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDetailPage : ContentPage
    {
        public DeviceDetailPage(string Name, string TypeOfDevice, bool PowerOn)
        {
            InitializeComponent();
            DeviceNameShow.Text = Name;
            DeviceTypeShow.Text = TypeOfDevice;
            PowerOnShow.Text = PowerCheck(PowerOn);

        }
        public string PowerCheck(bool powerOn)
        {
            if(powerOn == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}