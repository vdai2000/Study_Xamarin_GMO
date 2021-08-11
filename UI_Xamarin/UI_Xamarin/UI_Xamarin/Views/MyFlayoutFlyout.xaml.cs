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
                    new MyFlayoutFlyoutMenuItem { Id = 0, Title = "Page List PET" ,TargetType = typeof(Girdview),URL="https://noithattinnghia.com/wp-content/uploads/2019/03/cropped-icon-home-cam.png"},
                    new MyFlayoutFlyoutMenuItem { Id = 1, Title = "Page WebView" ,TargetType = typeof(WebView),URL="https://noithattinnghia.com/wp-content/uploads/2019/03/cropped-icon-home-cam.png"},
                    new MyFlayoutFlyoutMenuItem { Id = 2, Title = "Page List IMG" ,TargetType = typeof(ListIMG),URL="https://noithattinnghia.com/wp-content/uploads/2019/03/cropped-icon-home-cam.png"},
                    new MyFlayoutFlyoutMenuItem { Id = 3, Title = "Page Carousel" ,TargetType = typeof(CarouselPage),URL="https://noithattinnghia.com/wp-content/uploads/2019/03/cropped-icon-home-cam.png"},
                    new MyFlayoutFlyoutMenuItem { Id = 4, Title = "Page 5" ,TargetType = typeof(RelativeLayout),URL="https://noithattinnghia.com/wp-content/uploads/2019/03/cropped-icon-home-cam.png"},
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