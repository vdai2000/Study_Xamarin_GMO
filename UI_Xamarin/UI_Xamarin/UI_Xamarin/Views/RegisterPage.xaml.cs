using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Xamarin.Models;
using UI_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        AddItemVM user = new AddItemVM();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Register_ClickedAsync(object sender, EventArgs e)
        {
            string FullName = ET_FullName.Text.ToString();
            string Username = ET_User.Text.ToString();
            string Pass = ET_Password.Text.ToString();
            string Gender = "";
            string Date = startDatePicker.Date.ToString();
            if (CheckBoolAndPassVerify())
            {
                User newItem = new User(FullName,Username,Pass,Gender,Date);
                if(user.AddUser(newItem))
                {
                    List<User> list = user.GetAllUser();
                    DisplayAlert("Success", "Register Complete", "OK");
                    Navigation.PushModalAsync(new MainPage(user));
                }
                else
                {
                    //await DisplayAlert("ERROR", "Register Complete", "OK");
                }

                
            }
                
            
        }

        public bool CheckBoolAndPassVerify()
        {
            if (ET_FullName == null)
            {
                if (ET_User == null)
                {
                    if (ET_Password == null || ET_Verify == null)
                    {
                        if (ET_Password.Text != ET_Verify.Text)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}