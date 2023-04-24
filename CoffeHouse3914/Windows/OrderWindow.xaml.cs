using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoffeHouse3914.ClassHelper;
using CoffeHouse3914.DB;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
            GetOrder ();
        }
        private void GetOrder()
        {
            List<Check> stuffList = new List<Check>();

            stuffList = EFClass.Context.Check.ToList();

            LvProductList.ItemsSource = stuffList;
        }
    }
}
