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
using System.IO;

namespace Гороскопп
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtYear.MaxLength = 4;
            int y;
            int.TryParse(txtYear.Text, out y);
            if (y / 1000!=0&&y<2025&&y>1900)
            {
                imgAnimal.Visibility = Visibility.Visible;
                btnNext.Visibility = Visibility.Visible;
                btnClose.Visibility = Visibility.Visible;
                txtYear.IsEnabled = false;
                while (y > 0)
                {
                    y -= 12;
                }
                switch (y)
                {
                    case -8:
                        lblDate.Content = "Вы родились в год Крысы";
                        lblDate.FontSize = 24;
                        break;
                    case -7:
                        lblDate.Content = "Вы родились в год Быка";
                        lblDate.FontSize = 24;
                        break;
                    case -6:
                        lblDate.Content = "Вы родились в год Тигра";
                        lblDate.FontSize = 24;
                        break;
                    case -5:
                        lblDate.Content = "Вы родились в год Кролика";
                        lblDate.FontSize = 24;
                        break;
                    case -4:
                        lblDate.Content = "Вы родились в год Дракона";
                        lblDate.FontSize = 24;
                        break;
                    case -3:
                        lblDate.Content = "Вы родились в год Змеи";
                        lblDate.FontSize = 24;
                        break;
                    case -2:
                        lblDate.Content = "Вы родились в год Лошади";
                        lblDate.FontSize = 24;
                        break;
                    case -1:
                        lblDate.Content = "Вы родились в год Козы";
                        lblDate.FontSize = 24;
                        break;
                    case 0:
                        lblDate.Content = "Вы родились в год Обезьяны";
                        lblDate.FontSize = 24;
                        break;
                    case -11:
                        lblDate.Content = "Вы родились в год Петуха";
                        lblDate.FontSize = 24;
                        break;
                    case -10:
                        lblDate.Content = "Вы родились в год Собаки";
                        lblDate.FontSize = 24;
                        break;
                    case -9:
                        lblDate.Content = "Вы родились в год Свиньи";
                        lblDate.FontSize = 24;
                        break;
                }
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Signn window = new Signn();
            window.Show();
        }

        private void txtYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;  // Если символ не цифра, отменяем ввод
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
    }
    

