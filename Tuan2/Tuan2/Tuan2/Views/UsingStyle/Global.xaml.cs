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
    public partial class Global : ContentPage
    {
        public Global()
        {
            InitializeComponent();
            Button button = new Button();
            button.Text = "This button created in code behind and set global style";
            button.Style = (Style)Application.Current.Resources["Btn_style"];
            stackLayouyGlobal.Children.Add(button);
        }
    }
}