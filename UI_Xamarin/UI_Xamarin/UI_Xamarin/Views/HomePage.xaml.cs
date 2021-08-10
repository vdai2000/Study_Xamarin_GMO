using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Xamarin.Models;
using UI_Xamarin.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        PETViewModels pvm;
        PET pet;
        public HomePage()
        {
            InitializeComponent();
            pvm = new PETViewModels(Navigation);
            string myValue = Preferences.Get("username", "");
            Hello.Title = "Xin Chào " + myValue;
        }

        private void Button_Search_Clicked(object sender, EventArgs e)
        {
            string name = IP_NamePET.Text;
            pet = pvm.GetPETByName(name);

            NamePET.Text = pet.NamePet;
            imgPET.Source = ImageSource.FromUri(new Uri(pet.ImgPet));

        }

        private void Button_Detail_Clicked(object sender, EventArgs e)
        {
            /*if(pet != null)
            {
                Navigation.PushModalAsync(new DetailPET(pet.NamePet.ToString()));
            }
            else
            {
                DisplayAlert("Alert", "You have been alerted", "OK");
            }*/
        }
    }
}