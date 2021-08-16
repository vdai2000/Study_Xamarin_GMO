using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tuan2.Models;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Navi_Page2_Clicked(object sender, EventArgs e)
        {
            PET pET = new PET("Nam","Lay");
            Page2 page2 = new Page2();
            page2.BindingContext = pET;
            Navigation.PushAsync(page2);
        }

        private void Navi_Main_Page_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}