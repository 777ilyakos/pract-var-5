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

namespace _12
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

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int lenghtA = Convert.ToInt32(textA.Text);
                int lenghtB = Convert.ToInt32(textA.Text);
                int lenghtC = Convert.ToInt32(textA.Text);
                task1S.Content = "площадь: " + (2 * (lenghtA * lenghtB + lenghtB * lenghtC + lenghtC * lenghtA)).ToString();
                task1V.Content = "обьём: " + (lenghtA * lenghtB * lenghtC).ToString();
            }
            catch
            {
                MessageBox.Show("ваши данные не верны");
            }
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(task2Count.Text);
                task2Sum.Content = "сумма: " + (count / 10 + count % 10).ToString();
                task2Pov.Content = "произведение: " + (count / 10 * count % 10).ToString();
            }
            catch 
            {
                MessageBox.Show("вашша даннная не вернна");
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косоуров Илья ИСП-31 \n\nздесь нет иформации");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
