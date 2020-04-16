using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Smart_Home_System.ViewModel;
using Smart_Home_System.Model.ScriptsManager;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScriptsPage : ContentPage
    {
        public ScriptsPage()
        {
            InitializeComponent(); 
            BindingContext = new ScriptsListViewModel();
        }
        private async void OnScriptTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as ScriptModel;
            await Navigation.PushAsync(new ScriptDetailPage(details.Name, details.Detail));
        }
    }
}