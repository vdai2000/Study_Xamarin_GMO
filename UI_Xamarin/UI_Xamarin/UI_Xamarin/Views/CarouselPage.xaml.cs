using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage : ContentPage
    {
        PETViewModels _petvm;
        public CarouselPage()
        {
            InitializeComponent();
            _petvm = new PETViewModels(Navigation);
            BindingContext = _petvm;
            LoadScroll();
        }
        public void LoadScroll()
        {          
            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
                    {
                        mainCarousel.Position = (mainCarousel.Position + 1) % _petvm.ListImage.Count;
                        return true;
            }));
        }
    }
}