using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tuan2.Views;
using Tuan2.Views.FloytLayout;
using Tuan2.Views.Trigger;
using Tuan2.Views.Behaviors;
using Tuan2.Views.Themes;

namespace Tuan2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var Btn_style = new Style(typeof(Button))
            {
                Setters = {
                new Setter { Property = Button.TextColorProperty,    Value = Color.Blue },
                new Setter { Property = Button.FontSizeProperty,    Value = "30" }
            }
            };
            Resources.Add("Btn_style", Btn_style);
            /*MainPage = new UsingLightMode();*/
            /*MainPage = new FlyoutPageDemo();*/
            /*MainPage = new NavigationPage(new MainPage());*/
            MainPage = new UsingEventCommand();

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
