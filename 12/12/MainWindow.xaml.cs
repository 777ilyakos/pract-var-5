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
using System.Windows.Threading;

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
            this.DataContext = this;
            DispatcherTimer refresh = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 1, 0), IsEnabled = true };
            refresh.Tick += Refresh;
        }
        private void Refresh(object sender, EventArgs e)
        {
            DateTime dateAndTime = DateTime.Now;
            date.Text = dateAndTime.ToString("dd MMMM yyyy");
            time.Text = dateAndTime.ToString(" HH: mm: ss");
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double lenghtA = Convert.ToDouble(textA.Text);
                double lenghtB = Convert.ToDouble(textB.Text);
                double lenghtC = Convert.ToDouble(textC.Text);
                task1S.Content = "площадь: " + Math.Round(2 * (lenghtA * lenghtB + lenghtB * lenghtC + lenghtC * lenghtA), 2).ToString();
                task1V.Content = "обьём: " + Math.Round(lenghtA * lenghtB * lenghtC, 3).ToString();
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
                task2Pov.Content = "произведение: " + ((count / 10) * (count % 10)).ToString();
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
