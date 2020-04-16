using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Smart_Home_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScriptDetailPage : ContentPage
    {
        public ScriptDetailPage(string Name, string Detail)
        {
            InitializeComponent();
            ScriptNameShow.Text = Name;
            ScriptDetailShow.Text = Detail;
        }
    }
}