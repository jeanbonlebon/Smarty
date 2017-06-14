using Smarty.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Smarty.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class List : Page
    {
        public List()
        {
            this.InitializeComponent();
            ObservableCollection<Car> dataList = new ObservableCollection<Car>();
            Car c1 = new Car() { Brand = "Ferrari", Model = " Lamborghinis", Color = "Red" };
            Car c2 = new Car() { Brand = "Honda", Model = "GLI", Color = "Black" };
            Car c3 = new Car() { Brand = "Porsche", Model = "968 snowplow", Color = "White" };
            dataList.Add(c1);
            dataList.Add(c2);
            dataList.Add(c3);
            CarList.ItemsSource = dataList;
        }
    }
}
