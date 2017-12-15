using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Week9PrismExampleApp.ViewModels;
using Prism.Navigation;
using System.Net.Http;
using System.IO;
using System.Reflection;

namespace Week9PrismExampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();
        }
    }
}