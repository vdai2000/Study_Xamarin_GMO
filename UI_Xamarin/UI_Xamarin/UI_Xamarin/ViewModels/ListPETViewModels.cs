using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Service;
using UI_Xamarin.Models;

namespace UI_Xamarin.ViewModels
{
    public class ListPETViewModels
    {
        public DataPET PET;
        public ListPETViewModels()
        {
            PET = new DataPET();
        }
    }
}
