using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeWorkoutApp.Views.Articles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticlesHome : ContentPage
    {
        public ArticlesHome()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#0080FF");
        }
    }
}