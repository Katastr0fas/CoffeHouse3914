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
using CoffeHouse3914.Windows;
using CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegWindow reg = new RegWindow();
            reg.Show();
            this.Close();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var authUser = EFClass.Context.Emploee.ToList().Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();
            if (authUser != null)
            {
                ClassHelper.UserDataClass.Emploee = authUser;
                MessageBox.Show("Вход выполнен");
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}