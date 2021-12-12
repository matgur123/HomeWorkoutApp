using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeWorkoutApp.Models;
using HomeWorkoutApp.Views;

namespace HomeWorkoutApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }
          public User CurrentUser { get; set; }
        public static bool IsDevEnv
        {
            get
            {
                return true; //change this before release!
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
