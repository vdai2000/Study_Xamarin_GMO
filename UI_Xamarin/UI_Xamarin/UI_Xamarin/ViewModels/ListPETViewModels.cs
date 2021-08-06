using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Service;
using UI_Xamarin.Models;

namespace UI_Xamarin.ViewModels
{
    public class ListPETViewModels
    {
        private List<PET> list;
        private DataPET pET;

        

        public ListPETViewModels()
        {
            PET = new DataPET();
            List = PET.listpet;
        }

        public List<PET> List { get => list; set => list = value; }
        public DataPET PET { get => pET; set => pET = value; }
    }
}
