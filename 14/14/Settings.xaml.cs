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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public int RowCount { get; private set; }
        public int ColumnCount { get; private set; }
        public Settings(int rowCount = 0, int columnCount = 0)
        {
            InitializeComponent();
            RowCount = rowCount;
            ColumnCount = columnCount;
            rowText.Text = rowCount.ToString();
            columnText.Text = columnCount.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(rowText.Text, out int row) && row < 1)
            {
                MessageBox.Show("Укажите верное число строк", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!int.TryParse(columnText.Text, out int column) && column < 1)
            {
                MessageBox.Show("Укажите верное число столбцов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            RowCount = row;
            ColumnCount = column;
            this.Close();
        }
    }
}
