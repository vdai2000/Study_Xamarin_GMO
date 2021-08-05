using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UI_Xamarin.Views;
using UI_Xamarin.ViewModels;

namespace UI_Xamarin
{
    public partial class MainPage : ContentPage
    {
        AddItemVM xl = new AddItemVM();
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string user = ID.Text;
            string pass = Pass.Text;
            if (xl.CheckLogin(user,pass))
            {
                await Navigation.PushModalAsync(new MyFlayout());
            }
        }
    }
}
