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
using System.Collections.ObjectModel;
using CoffeHouse3914.Windows;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            Getlistproduct();
        }
        private void Getlistproduct()
        {
            ObservableCollection<DB.Stuff> stuffs= new ObservableCollection<DB.Stuff>(ClassHelper.CartClass.stuffs);
            LvCartList.ItemsSource= stuffs;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Stuff;
            if (selectedProduct != null)
            {
                ClassHelper.CartClass.stuffs.Remove(selectedProduct);
                Getlistproduct();
            }
        }
    }
}
