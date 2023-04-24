using CoffeHouse3914.ClassHelper;
using Microsoft.Win32;
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

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeAddEmployeeWindow.xaml
    /// </summary>
    public partial class ChangeAddEmployeeWindow : Window
    {
        public ChangeAddEmployeeWindow()
        {
            InitializeComponent();
            CMBGender.ItemsSource = EFClass.Context.Gender.ToList();
            CMBPostEmployee.ItemsSource = EFClass.Context.Post.ToList();
            CMBGender.SelectedIndex = 1;
            CMBPostEmployee.SelectedIndex = 1;
            CMBGender.DisplayMemberPath = "Gender1";
            CMBPostEmployee.DisplayMemberPath = "Title";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DB.Emploee emploee = new DB.Emploee();

            if (TbNameEmployee == null && TbPhoneEmployee == null && TBEmailEmployee == null && TBPasswordEmployee == null && TbLoginEmployee == null)
            {
                MessageBox.Show("Заполните все поля");
                return;

            }
            else
            {
                
                emploee.FullName = TbNameEmployee.Text;
                emploee.Phone = TbPhoneEmployee.Text;
                emploee.IDGender = (CMBGender.SelectedItem as DB.Gender).IDGender;
                emploee.Birthday = (DateTime)DPBirthday.SelectedDate;
                emploee.Email = TBEmailEmployee.Text;
                emploee.Login = TbLoginEmployee.Text;
                emploee.Password = TBPasswordEmployee.Text;
                emploee.IDPost = (CMBPostEmployee.SelectedItem as DB.Post).IdPost;


                EFClass.Context.Emploee.Add(emploee);

                EFClass.Context.SaveChanges();
                MessageBox.Show("Работник  добавлен");

            }
        }

    }
}