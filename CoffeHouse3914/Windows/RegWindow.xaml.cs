using CoffeHouse3914.ClassHelper;
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

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            CmbGender.ItemsSource = EFClass.Context.Gender.ToList();
            CmbGender.SelectedIndex = 0;
            CmbGender.DisplayMemberPath = "Gender1";
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            auth.Show();
            this.Close();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLogin.Text))
            {
                MessageBox.Show("Логин не может быть введен");
                return;
            }

            var authUser = EFClass.Context.Guest.ToList().Where(i => i.Login == TbLogin.Text).FirstOrDefault();
            if (authUser != null)
            {
                MessageBox.Show("Данные введены не верно");

            }
            else if (TbEMail.Text != "" && TbFirstName.Text != "" && TbPhone.Text != "" && PbPassword.Password == PbPasswordSecond.Password && PbPassword.Password != "")
            {

                DB.Guest guest = new DB.Guest();
                guest.Login = TbLogin.Text;
                guest.Name = TbFirstName.Text;
                guest.Email = TbEMail.Text;
                guest.Phone = TbPhone.Text;
                guest.IDGender = (CmbGender.SelectedItem as DB.Gender).IDGender;
                guest.Birthday = CBirthDate.SelectedDate.Value;
                guest.Password = PbPassword.Password;
                EFClass.Context.Guest.Add(guest);

                MessageBox.Show("регистрация выполнена");
                EFClass.Context.SaveChanges();
                AuthWindow auth = new AuthWindow();
                auth.Show();
                this.Close();
            }



        }
        private void TextBlock_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            this.Close();
            auth.Show();    
        }
    }
}
