using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2.Views.UsingStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dynamic : ContentPage
    {
        bool clicked = true;
        public Dynamic()
        {
            InitializeComponent();
            Resources["labelStyle"] = Resources["blueStyle"];
        }
        private void Handle_Clicked(object sender, EventArgs e)
        {
            if (clicked)
            {
                Resources["labelStyle"] = Resources["redStyle"];
                clicked = false;
            }
            else
            {
                Resources["labelStyle"] = Resources["blueStyle"];
                clicked = true;
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (clicked)
            {
                Resources["labelCustomStyle"] = Resources["redStyle"];
                clicked = false;
            }
            else
            {
                Resources["labelCustomStyle"] = Resources["blueStyle"];
                clicked = true;
            }
        }
    }
}