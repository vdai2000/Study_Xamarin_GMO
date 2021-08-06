using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI_Xamarin.Models;

namespace UI_Xamarin.Service
{
    public class Data
    {
        public List<User> items;
        public Data()
        {
            items = new List<User>()
            {
                new User("Dương Văn Đại","Nam","123","Nam","26/03/2000"),
                new User("Dương Văn Đại","Dai","123","Nam","26/03/2000")
            };
        }
        public bool AddUser(User item)
        {
            items.Add(item);
            return true;
        }
        public User GetItemAsync(string id)
        {
            return items.FirstOrDefault(s => s.Username == id);
        }

        public List<User> GetALLUser ()
        {
            List<User> list = items.ToList();
            return list;
        }
    }
}
