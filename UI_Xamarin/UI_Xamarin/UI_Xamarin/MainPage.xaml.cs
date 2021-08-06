using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using UI_Xamarin.Views;
using UI_Xamarin.ViewModels;
using Xamarin.Essentials;

namespace UI_Xamarin
{
    public partial class MainPage : ContentPage
    {
        AddItemVM xl;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            xl = new AddItemVM();
        }

        public MainPage(AddItemVM data)
        {
            xl = data;
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string user = ID.Text;
            string pass = Pass.Text;
            if (xl.CheckLogin(user,pass))
            {
                Preferences.Set("username", user);
                await Navigation.PushModalAsync(new MyFlayout());
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
