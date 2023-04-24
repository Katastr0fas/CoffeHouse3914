using CoffeHouse3914.DB;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CoffeHouse3914.ClassHelper;
using CoffeHouse3914.Windows;

namespace CoffeHouse3914
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TbNamePost.Text = UserDataClass.Emploee.FullName + "\n" + UserDataClass.Emploee.Post.Title;
        }

        private void BtnOrderList_Click(object sender, RoutedEventArgs e)
        {

            OrderWindow orderWindow = new OrderWindow();
            this.Hide();
            orderWindow.ShowDialog();
            this.Show();
        }

        private void BtnEmployeeList_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            this.Hide();
            employeeWindow.ShowDialog();
            this.Show();
        }

        private void BtnProductList_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.Show();
        }
    }
}