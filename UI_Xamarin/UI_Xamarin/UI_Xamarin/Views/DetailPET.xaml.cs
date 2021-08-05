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
        PETViewModels view = new PETViewModels();
        public DetailPET(string namepet)
        {
            

            InitializeComponent();

            PET pet = view.GetPETByName(namepet);

            Ten.Text = pet.NamePet;
            Loai.Text = pet.Type;
            Mota.Text = pet.Distription;
            Hinh.Source = ImageSource.FromUri(new Uri(pet.ImgPet));
        }
    }
}