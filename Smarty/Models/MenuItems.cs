using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;

namespace Smarty.Models
{
    public class MenuItem : ViewModelBase
    {
        public string Title { get; set; }

        public Symbol SymbolIcon { get; set; }

        public Type NavigateTo { get; set; }
    }
}