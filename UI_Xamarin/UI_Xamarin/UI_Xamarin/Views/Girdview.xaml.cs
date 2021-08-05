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
        public ListPETViewModels view;
        public Girdview()
        {
            InitializeComponent();
            view = new ListPETViewModels();
            BindingContext = view.PET.pet;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}