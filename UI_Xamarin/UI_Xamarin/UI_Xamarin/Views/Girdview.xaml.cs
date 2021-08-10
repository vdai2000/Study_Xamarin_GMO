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
    public partial class Girdview : ContentPage
    {
        public ListPETViewModels View;
        public Girdview()
        {         
            InitializeComponent();
            View = new ListPETViewModels(Navigation);
            BindingContext = View;
        }
    }
}