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
        AddItemVM loginViewModels;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            loginViewModels = new AddItemVM(Navigation);
            BindingContext = loginViewModels;
            

        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            /*RegisterPage registerPage = new RegisterPage();
            registerPage.BindingContext = loginViewModels;*/
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
