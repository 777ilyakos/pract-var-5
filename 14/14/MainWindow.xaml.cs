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
using LibMas;
using Microsoft.Win32;

namespace _14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] _matrix;
        public MainWindow()
        {
            InitializeComponent();

            Password password = new Password();
            //password.Owner = this;
            password.ShowDialog();

            this.DataContext = this;
            DispatcherTimer refresh = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1), IsEnabled = true };
            refresh.Tick += Refresh;
        }
        private void Refresh(object sender, EventArgs e)
        {
            DateTime dateAndTime = DateTime.Now;
            date.Text = dateAndTime.ToString("dd.MMMM.yyyy");
            time.Text = dateAndTime.ToString("HH:mm:ss");
        }
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int row = Convert.ToInt32(rowText.Text);
                int column = Convert.ToInt32(columnText.Text);
                _matrix = new int[row, column];
                arrayHelper.Fill(_matrix, 10);
                table.ItemsSource = VisualArray.ToDataTable(_matrix).DefaultView;
                sizeText.Text = string.Format("Размер таблицы: {0}х{1}", row, column);
            }
            catch
            {
                MessageBox.Show("вы ввели не верные данные");
            }
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int index = 0;
                bool key = false;
                for (int i = 0; i < _matrix.GetLength(1); i++)
                {
                    if (key)
                    {
                        index = i;
                        break;
                    }

                    key = true;

                    for (int j = 0; j < _matrix.GetLength(0); j++)
                    {
                        if (_matrix[j, i] % 2 == 0)
                        {
                            key = false;
                            break;
                        }
                    }
                }

                result.Text = index.ToString();
            }
            catch
            {
                MessageBox.Show("Неверное входное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Table_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //Определяем номер столбца
            int columnIndex = e.Column.DisplayIndex;
            //Определяем номер строки
            int rowIndex = e.Row.GetIndex();
            //Заносим полученное значение в массив
            if (int.TryParse(((TextBox)e.EditingElement).Text, out int value))
                _matrix[rowIndex, columnIndex] = value;
            InputValue_TextChanged(this, null);
        }

        private void InputValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (result == null) return;
            result.Clear();
        }

        private void table_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            //Определяем номер столбца
            int columnIndex = e.Column.DisplayIndex;
            //Определяем номер строки
            int rowIndex = e.Row.GetIndex();
            selectedText.Text = string.Format("Выбранная ячейка: {0}х{1}", rowIndex, columnIndex);
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_matrix == null)
            {
                MessageBox.Show("Сначала создайте таблицу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы (*.txt*) | *.txt*";
            save.FilterIndex = 2;
            save.Title = "Сохранить Таблицы";
            if (save.ShowDialog() == true)
            {
                arrayHelper.Save(_matrix, save.FileName);
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы (*.txt*) | *.txt*";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицы";
            if (open.ShowDialog() == true)
            {
                arrayHelper.Open(out _matrix, open.FileName);
                //Выводим массив на форму
                table.ItemsSource = VisualArray.ToDataTable(_matrix).DefaultView;
                sizeText.Text = string.Format("Размер таблицы: {0}х{1}", _matrix.GetLength(0), _matrix.GetLength(1));
                rowText.Text = _matrix.GetLength(0).ToString();
                columnText.Text = _matrix.GetLength(1).ToString();
                InputValue_TextChanged(this, null);
                selectedText.Text = string.Format("Выбранная ячейка: {0}х{1}", 0, 0);
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разарботчик - Косоуров Илья ИСП-31");
        }

        private void table_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            selectedText.Text = string.Format("Выбранная ячейка: {0}х{1}", table.CurrentColumn.DisplayIndex + 1, table.Items.IndexOf(table.CurrentItem) + 1);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            rowText.Text = "0";
            columnText.Text = "0";
            //inputValue.Text = "0";
        }

    }
}
