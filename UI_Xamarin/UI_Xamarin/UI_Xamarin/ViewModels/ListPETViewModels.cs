using System;
using System.Collections.Generic;
using System.Text;
using UI_Xamarin.Service;
using UI_Xamarin.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using UI_Xamarin.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UI_Xamarin.ViewModels
{
    public class ListPETViewModels : INotifyPropertyChanged
    {
        private List<PET> list;
        private DataPET pET;
        private List<PET> _list;
        private List<PET> _resultSeach;
        private ICommand detailCommand;
        private INavigation _navigation;
        private Command<string> _searchCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void Search(string query)
        {
            ResultSeach = new List<PET>();
            List = PET.listpet;
            foreach(PET pet in List)
            {
                if(pet.NamePet.Contains(query))
                {
                    ResultSeach.Add(pet);
                }
            }
            List = ResultSeach;
        }
        public ListPETViewModels(INavigation navigation)
        {
            PET = new DataPET();
            Navigation = navigation;
            List = PET.listpet;
            DetailCommand = new Command(async (obj) => await LoadDetailPage(obj));
            SearchCommand = new Command<string>((query) => Search(query));
        }
        public async Task LoadDetailPage(object obj)
        {
            var a = new DetailPET();
            a.BindingContext = obj;
            await Navigation.PushModalAsync(a);
        }
        
        public ICommand DetailCommand { get => detailCommand; set => detailCommand = value; }
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
        public List<PET> List {
            get
            {
                return list;
            }
            set
            {
                list = value;
                NotifyPropertyChanged();
            }
        }
    public DataPET PET { get => pET; set => pET = value; }
        public Command<string> SearchCommand { get => _searchCommand; set => _searchCommand = value; }
        public List<PET> ListPet { get => _list; set => _list = value; }
        public List<PET> ResultSeach { get => _resultSeach; set => _resultSeach = value; }
    }
}
