using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2 {
    public partial class MainPage : ContentPage {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sauna_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new SaunaControlling());
        }

        private void Lämmöt_Clicked_1(object sender, EventArgs e) {
            Navigation.PushAsync(new LampoControlling());
        }
    }
}
