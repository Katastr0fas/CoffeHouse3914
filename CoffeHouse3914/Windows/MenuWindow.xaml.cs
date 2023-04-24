using CoffeHouse3914.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using static CoffeHouse3914.ClassHelper.EFClass;
using  CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            if (UserDataClass.Emploee.IDPost != 1)
            {
                BtnAddProduct.Visibility = Visibility.Collapsed;
            }
            GetProducr();
        }

        private void GetProducr()
        {
            List<Stuff> stuffList = new List<Stuff>();

            stuffList = EFClass.Context.Stuff.ToList();

            LvProductList.ItemsSource = stuffList;
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            MenuChangeWindow menuChange = new MenuChangeWindow();

            this.Hide();
            menuChange.ShowDialog();
            this.Show();
        }

      

        private void GoToCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            this.Hide();
            cartWindow.ShowDialog();
            this.Show();
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
                ClassHelper.CartClass.stuffs.Add(selectedProduct);
            }
        }
    }
}
