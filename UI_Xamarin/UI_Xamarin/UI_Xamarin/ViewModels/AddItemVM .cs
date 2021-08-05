using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using Xamarin.Forms;
using UI_Xamarin.Service;
namespace UI_Xamarin.ViewModels
{
    public class AddItemVM
    {
        Data data = new Data();
        public bool CheckLogin(string name, string password)
        {
            User nam = data.GetItemAsync(name);
            if (nam.Pass == password)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
