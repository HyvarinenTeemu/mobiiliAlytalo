using App2.Models;
using Java.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace App2.ViewModels {
    public class AppUser : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        
        private DateTime lastTimeUp;

        public DateTime LastTimeUp {
            get {
                return lastTimeUp;
            }
            set {
                if(lastTimeUp != value) {
                    lastTimeUp = value;
                    PropertyChange("LasteTimeUp");
                }
            }
        }


        public async Task GetSaunaInfo() {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://alytaloweb20171122020453.azurewebsites.net/sauna/haesaunatiedot");

            dynamic tes = JsonConvert.DeserializeObject(response);
            
            foreach(var obj in tes.AppUserEnd) {
                var whoused = obj.WhousedLast;
            }
            
        }

        public void PropertyChange(string prop) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
