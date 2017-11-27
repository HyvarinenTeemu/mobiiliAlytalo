using App2.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2 {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaunaControlling : ContentPage {
        
        public SaunaControlling() {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}