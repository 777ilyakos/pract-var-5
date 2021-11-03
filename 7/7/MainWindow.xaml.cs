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

namespace _7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Triangle triangle = new Triangle(0);
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            InformationWindow Information = new InformationWindow();
            Information.Show();
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Int32.TryParse(e.Text, out int val))
            {
                e.Handled = true; // отклоняем ввод
            }
            
        }
        private void IncreaseLengths2(object sender, RoutedEventArgs e)
        {
            triangle.SetParams(Convert.ToInt32(length1.Text), Convert.ToInt32(length2.Text), Convert.ToInt32(length3.Text));
            triangle.IncreaseLengths();
            length1.Text = triangle.length1.ToString();
            length2.Text = triangle.length2.ToString();
            length3.Text = triangle.length3.ToString();
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            triangle.SetParams(Convert.ToInt32(length1.Text), Convert.ToInt32(length2.Text), Convert.ToInt32(length3.Text));
            if (triangle)
                MessageBox.Show("треугольник с данными сторонами может существовать");
            else
                MessageBox.Show("треугольник с данными сторонами не может существовать");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            triangle.SetParams(Convert.ToInt32(length1.Text), Convert.ToInt32(length2.Text), Convert.ToInt32(length3.Text));
            triangle--;
            length1.Text = triangle.length1.ToString();
            length2.Text = triangle.length2.ToString();
            length3.Text = triangle.length3.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            triangle.SetParams(Convert.ToInt32(length1.Text), Convert.ToInt32(length2.Text), Convert.ToInt32(length3.Text));
            triangle++;
            length1.Text = triangle.length1.ToString();
            length2.Text = triangle.length2.ToString();
            length3.Text = triangle.length3.ToString();
        }
    }
}
