using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Smart_Home_System.ViewModel;
using Smart_Home_System.Views;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemperatureMenuPage : ContentPage
    {
        public TemperatureMenuPage()
        {
            InitializeComponent();
        }

        private void ToggleAction(object sender, ToggledEventArgs e)
        {
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }
    }
}