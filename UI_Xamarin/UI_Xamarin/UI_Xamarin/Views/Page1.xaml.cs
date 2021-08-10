using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI_Xamarin.ViewModels;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public PETViewModels _petvm;
        public Page1()
        {
            InitializeComponent();
            _petvm = new PETViewModels(Navigation);
            BindingContext = _petvm;
        }
    }
}