using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Xamarin.Models
{
    public class User
    {
        private string _fullName;
        private string _user;
        private string _pass;
        private string _gender;
        private DateTime _date;

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

        public string FullName { get => _fullName; set => _fullName = value; }
        public string Username { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
