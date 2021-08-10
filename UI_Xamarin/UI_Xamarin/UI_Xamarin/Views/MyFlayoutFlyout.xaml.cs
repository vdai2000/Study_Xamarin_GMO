using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlayoutFlyout : ContentPage
    {
        public ListView ListView;

        public MyFlayoutFlyout()
        {
            InitializeComponent();
            
            BindingContext = new MyFlayoutFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MyFlayoutFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlayoutFlyoutMenuItem> MenuItems { get; set; }

            public MyFlayoutFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlayoutFlyoutMenuItem>(new[]
                {
                    new MyFlayoutFlyoutMenuItem { Id = 0, Title = "Page 1" ,TargetType = typeof(Girdview)},
                    new MyFlayoutFlyoutMenuItem { Id = 1, Title = "Page 2" ,TargetType = typeof(WebView)},
                    new MyFlayoutFlyoutMenuItem { Id = 2, Title = "Page 3" ,TargetType = typeof(ListIMG)},
                    new MyFlayoutFlyoutMenuItem { Id = 3, Title = "Page 4" ,TargetType = typeof(AbsoluteLayout)},
                    new MyFlayoutFlyoutMenuItem { Id = 4, Title = "Page 5" ,TargetType = typeof(RelativeLayout)},
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