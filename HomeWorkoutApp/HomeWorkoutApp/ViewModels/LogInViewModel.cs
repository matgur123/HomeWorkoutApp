using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using HomeWorkoutApp.Views;
using System.ComponentModel;
using HomeWorkoutApp.Services;
using HomeWorkoutApp.Models;
namespace HomeWorkoutApp.ViewModels
{
    class LogInViewModel : INotifyPropertyChanged
    {
        //updates views and viewmodels. when changing variables it updates
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Command RegisterCommand { protected set; get; }
        public Command LoginCommand { protected set; get; }

        public LogInViewModel()
        {
            EmailError = "Must be a valid email address";

            this.LoginCommand = new Command(() => Login());
            this.RegisterCommand = new Command(() => Register());

           HomeWorkoutAPIProxy.CreateProxy();
        }




    }
}
