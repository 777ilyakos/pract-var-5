using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _14
{
    /// <summary>
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
            pass.Focus();
        }

        private void Vod_Click(object sender, RoutedEventArgs e)
        {
            if (pass.Text == "123")
            {
                MainWindow window = new MainWindow();
                this.Close();
                window.Show();
            }
            else
            {
                MessageBox.Show("пароль не верен");
            }
        }
        private void Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Vod_Click(sender, e);
            }
        }
    }
}
