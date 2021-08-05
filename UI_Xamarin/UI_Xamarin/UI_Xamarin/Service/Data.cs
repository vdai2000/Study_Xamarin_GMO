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
                new User("Nam","123"),
                new User("Dai","123")
            };
        }
        public bool AddUser(User item)
        {
            items.Add(item);
            return true;
        }
        public User GetItemAsync(string id)
        {
            return items.FirstOrDefault(s => s.Name == id);
        }

        public List<User> GetUser ()
        {
            List<User> list = items.ToList();
            return list;
        }
    }
}
