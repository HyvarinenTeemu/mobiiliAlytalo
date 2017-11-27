using App2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.ViewModels {
    public class HomeViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        private TaskModel _taskModel;
        private string _message;
        private string _whoUsedLast;

        public TaskModel TaskModel {
            get {
                return _taskModel;
            }
            set {
                _taskModel = value;
                OnPropertyChanged("TaskModel");
            }
        }

        public string Message {
            get {
                return _message;
            }
            set {
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        public string WhoUsedLast {
            get {
                return _whoUsedLast;
            }
            set {
                _whoUsedLast = value;
                OnPropertyChanged("WhoUsedLast");                
            }
        }

        public Command SaveCommand {
            get {
                return new Command(() => {
                    Message = "Testi " + TaskModel.Title + ", " + TaskModel.Duration + " was saved";
                });
            }
        }

        public Command GetLastInfo {
            get {
                return new Command(() => {
                    AppUser _appUser = new AppUser();

                    var test = _appUser.GetSaunaInfo();
                    
                });
            }
        }

        public HomeViewModel() {
            TaskModel = new TaskModel {
                Title = "Test",
                Duration = 2
            };
            
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
