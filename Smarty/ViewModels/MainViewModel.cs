using GalaSoft.MvvmLight;
using Smarty.Models;
using Smarty.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace Smarty.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>(GetMenuItems());
            SelectedMenuItem = MenuItems.FirstOrDefault();
        }

        public ObservableCollection<MenuItem> MenuItems { get; set; }

        private MenuItem selectedMenuItem;

        public MenuItem SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set { selectedMenuItem = value; RaisePropertyChanged(); }
        }

        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { Title = "Home", SymbolIcon = Symbol.Home, NavigateTo = typeof(Home) });
            menuItems.Add(new MenuItem() { Title = "Cars Available", SymbolIcon = Symbol.List, NavigateTo = typeof(List) });
            menuItems.Add(new MenuItem() { Title = "Add a Car", SymbolIcon = Symbol.Add, NavigateTo = typeof(Add) });
            menuItems.Add(new MenuItem() { Title = "Location", SymbolIcon = Symbol.Add, NavigateTo = typeof(Location) });

            return menuItems;
        }

   
    }
}