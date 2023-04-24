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
using CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            if (UserDataClass.Emploee.IDPost != 1)
            {
                BtnAddEmployee.Visibility = Visibility.Collapsed;
            }
            GetEmployee();
        }
        private void GetEmployee()
        {
            List<Emploee> stuffList = new List<Emploee>();

            stuffList = EFClass.Context.Emploee.ToList();

            LvProductList.ItemsSource = stuffList;
        }

        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            ChangeAddEmployeeWindow changeAddEmployeeWindow = new ChangeAddEmployeeWindow();
            this.Hide();
            changeAddEmployeeWindow.ShowDialog();
            this.Show();

        }
    }
}
