﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeWorkoutApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {

            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#0080FF");

        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Discover());
        }
    }
}