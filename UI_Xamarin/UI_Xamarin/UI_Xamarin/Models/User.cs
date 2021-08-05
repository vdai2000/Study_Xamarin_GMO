using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class User
    {
        private string name;
        private string pass;

        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }

        public User(string name, string pass)
        {
            this.Name = name;
            this.Pass = pass;
        }

    }
}
