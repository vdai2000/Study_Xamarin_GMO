using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tuan2.Views.UsingStyle;
using Tuan2.Views.Themes;
using Tuan2.Views.Trigger;
using Tuan2.Views.Behaviors;
using Tuan2.Views.TabbedPageUsing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2.Views.FloytLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageDemoFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPageDemoFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPageDemoFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPageDemoFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPageDemoFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPageDemoFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPageDemoFlyoutMenuItem>(new[]
                {
                    
                    new FlyoutPageDemoFlyoutMenuItem { Id = 0, Title = "Home - Navigation" ,TargetType=typeof(MainPage)},
                    new FlyoutPageDemoFlyoutMenuItem { Id = 1, Title = "Tabbed",TargetType=typeof(TabbedPageDemo) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 2, Title = "Explicit style",TargetType=typeof(Explicit) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 3, Title = "Implicit style ",TargetType=typeof(Implicit) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 4, Title = "Inhertance Style",TargetType=typeof(Inhertance) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 5, Title = "Global Style",TargetType=typeof(Global) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 6,Title = "Class style",TargetType=typeof(Class) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 7,Title = "Style CSS style",TargetType=typeof(StyleCSS) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 8, Title = "Dynamic style ",TargetType=typeof(Dynamic) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 9, Title = "Theme Style",TargetType=typeof(UsingLightMode) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 10, Title = "Trigger",TargetType=typeof(Property) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 11,Title = "Behaviors",TargetType=typeof(UsingBeharviors) },
                    new FlyoutPageDemoFlyoutMenuItem { Id = 12,Title = "Behavior EventCommand",TargetType=typeof(UsingEventCommand) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}