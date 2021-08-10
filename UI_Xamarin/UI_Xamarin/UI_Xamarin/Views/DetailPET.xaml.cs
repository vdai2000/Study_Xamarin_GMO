using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Xamarin.Models;
using UI_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPET : ContentPage
    {
        PETViewModels view;
        public DetailPET()
        {          

            InitializeComponent();
            view = new PETViewModels(Navigation);
        }
    }
}