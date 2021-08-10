using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using UI_Xamarin.Views;
using UI_Xamarin.Service;
using System.Threading.Tasks;

namespace UI_Xamarin.ViewModels
{
    public class AddItemVM
    {
        private INavigation _navigation;
        private Command _loginCommand;
        private Command _registerCommand;
        Data data = new Data();
        List<User> ListUser;

        private string userName;
        private string password;

        private string _usernameRegister, _passwordRegister, _nameRegister, _gender;
        private DateTime _birthdayRegister;

        public AddItemVM(INavigation navigation)
        {
            Navigation = navigation;
            ListUser = data.items;
            LoginCommand = new Command(async () => await CheckLogin());
            RegisterCommand = new Command(async () => await Register());
        }

        public AddItemVM()
        {
           
            ListUser = data.items;
            LoginCommand = new Command(async () => await CheckLogin());
            RegisterCommand = new Command(async () => await Register());
        }
        public async Task CheckLogin()
        {
            User nam = data.GetItemAsync(UserName);
            if (nam.Pass.Equals(Password))
            {
                var homePage = new MyFlayout();
                homePage.BindingContext = nam;
                await Navigation.PushModalAsync(homePage);
                Preferences.Set("username", nam.FullName);
            }
        }
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
        public Command LoginCommand { get => _loginCommand; set => _loginCommand = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public Command RegisterCommand { get => _registerCommand; set => _registerCommand = value; }
        public string UsernameRegister { get => _usernameRegister; set => _usernameRegister = value; }
        public string PasswordRegister { get => _passwordRegister; set => _passwordRegister = value; }
        public string NameRegister { get => _nameRegister; set => _nameRegister = value; }
        public string GenderRegister { get => _gender; set => _gender = value; }
        public DateTime BirthdayRegister { get => _birthdayRegister; set => _birthdayRegister = value; }

        
        public async Task Register()
        {
            User name = new User(NameRegister, UsernameRegister, PasswordRegister, GenderRegister = "Nam", BirthdayRegister);
            ListUser.Add(name);
            MainPage homePage = new MainPage();
            homePage.BindingContext = this;
            await Navigation.PushModalAsync(homePage);

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
