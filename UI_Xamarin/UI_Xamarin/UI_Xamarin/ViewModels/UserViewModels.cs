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

        public bool CheckTrungUserName(string username)
        {
            if (data.GetItemAsync(username) != null)
            {
                return false;
            }
            return true;
        }

        public bool AddUser(User usernam)
        {
            if (CheckTrungUserName(usernam.Username))
            {
                data.AddUser(usernam);
                return true;
            }
            return false;
        }

        public List<User> GetAllUser ()
        {
            return data.GetALLUser();
        }
    }
}
