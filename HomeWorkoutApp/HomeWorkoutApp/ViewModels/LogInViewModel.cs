﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using HomeWorkoutApp.Views;
using System.ComponentModel;
using HomeWorkoutApp.Services;
using HomeWorkoutApp.Models;
using HomeWorkoutApp.ViewModels;
using System.Runtime.CompilerServices;
namespace HomeWorkoutApp.ViewModels
{
    class LogInViewModel : BaseViewModels
    {

        #region Properties
        private string email;

        public string Email
        {
            get => email;
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged();
                }
            }
        }

        private string password;

        public string Password
        {
            get => password;
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        private string status;

        public string Status
        {
            get => status;
            set
            {
                if (value != status)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        public ICommand ToSignUpCommand { get; set; }

        public ICommand ToForgotPassCommand { get; set; }
        #endregion
        public LogInViewModel()
        {
            Email = string.Empty;
            Password = string.Empty;
            Status = string.Empty;
            LoginCommand = new Command(Login);
            //ToSignUpCommand = new Command(ToSignUp);
            //ToForgotPassCommand = new Command(ToForgotPass);
        }

        private async void Login()
        {
            HomeWorkoutAPIProxy proxy = HomeWorkoutAPIProxy.CreateProxy();
            try
            {
                User u = await proxy.LoginAsync(Email, Password);
                Status = "Loging you in....";
                if (u != null)
                {
                    ((App)App.Current).CurrentUser = u;
                    Push?.Invoke(new StartPage());
                }
            }
            catch (Exception)
            {
                Status = "Something went wrong...";
            }
        }

        #region Events

        public event Action<Page> Push;

        #endregion




    }
}
