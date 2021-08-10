using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class User
    {
        private string fullName;
        private string user;
        private string pass;
        private string gender;
        private DateTime date;

        public User()
        {
        }

        public User(string fullName, string user, string pass, string gender, DateTime date)
        {
            this.FullName = fullName;
            this.Username = user;
            this.Pass = pass;
            this.Gender = gender;
            this.Date = date;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string Username { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
