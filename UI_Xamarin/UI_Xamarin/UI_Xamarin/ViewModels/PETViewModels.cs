using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using System.Linq;
using UI_Xamarin.Service;

namespace UI_Xamarin.ViewModels
{
    public class PETViewModels
    {
        DataPET dtPet = new DataPET();

        public PET GetPETByName(string name)
        {
            return dtPet.GetPETByName(name);
        }
    }
}
