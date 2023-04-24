using Microsoft.Win32;
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
using System.IO;
using  CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuChangeWindow.xaml
    /// </summary>
    public partial class MenuChangeWindow : Window
    {
        private string pathPhoto = null;
        public MenuChangeWindow()
        {
            InitializeComponent();
            CMBTypeProduct.ItemsSource = EFClass.Context.Category.ToList();
            CMBTypeProduct.SelectedIndex = 0;
            CMBTypeProduct.DisplayMemberPath = "Title";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DB.Stuff stuff = new DB.Stuff();

            if (TbNameProduct == null && CMBTypeProduct == null && TbCount == null)
            {
                stuff.Title = TbNameProduct.Text;
                stuff.Price = Convert.ToDecimal(TbPrice.Text);
                stuff.IDCategory = (CMBTypeProduct.SelectedItem as DB.Category).IDCategory;
                stuff.Count = Convert.ToInt32(TbCount.Text);
                stuff.ExpirationDate = Convert.ToInt32(TbDateLost.Text);
                if (pathPhoto != null)
                {
                    stuff.PhotoPath = File.ReadAllBytes(pathPhoto);
                }

                EFClass.Context.Stuff.Add(stuff);

                EFClass.Context.SaveChanges();
                MessageBox.Show("Товар  добавлен");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
                return;

            }
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
        }
    }
}

