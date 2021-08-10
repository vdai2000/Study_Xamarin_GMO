using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using System.Linq;
using Xamarin.Forms;
using UI_Xamarin.Views;
using UI_Xamarin.Service;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI_Xamarin.ViewModels
{
    public class PETViewModels
    {
        DataPET _dtPet;
        DataImagePET _dataImage;
        List<ImgPET> listImage;
        private ICommand detaiListImageCommand;
        private INavigation navigation;
        public DataPET DtPet { get => _dtPet; set => _dtPet = value; }
        public DataImagePET DataImage { get => _dataImage; set => _dataImage = value; }
        public List<ImgPET> ListImage { get => listImage; set => listImage = value; }
        public ICommand DetaiListImageCommand { get => detaiListImageCommand; set => detaiListImageCommand = value; }
        public INavigation Navigation { get => navigation; set => navigation = value; }

        public PETViewModels(INavigation navigation)
        {
            DtPet = new DataPET();
            DataImage = new DataImagePET();
            ListImage = DataImage.listImg;
            Navigation = navigation;
        }
        public PET GetPETByName(string name)
        {
            return DtPet.GetPETByName(name);
        }
        public async Task GetALLImageByName(object obj)
        {
            var listImg = new ListIMG();
            listImg.BindingContext = obj;
            await Navigation.PushAsync(listImg);
        }
    }
}
