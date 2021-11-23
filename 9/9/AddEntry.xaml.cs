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

namespace _9
{
    /// <summary>
    /// Логика взаимодействия для AddEntry.xaml
    /// </summary>
    public partial class AddEntry : Window
    {
        public Worker Record;
        public AddEntry(Worker record)
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (LastName.Text.Length == 0) errors.AppendLine("Введите фамилию");
            if (FirstName.Text.Length == 0) errors.AppendLine("Введите имя");
            if (SecondName.Text.Length == 0) errors.AppendLine("Введите отчество");
            if (Gender.Text.Length == 0) errors.AppendLine("Введите пол человека");
            if (Post.Text.Length == 0) errors.AppendLine("Введите должность работника");
            if (!int.TryParse(WorkExperience.Text, out _)) errors.AppendLine("Введите корректный стаж работы в месяцах");
            if (!int.TryParse(Salary.Text, out _)) errors.AppendLine("Введите корректную заработную плату в рублях");

            if (errors.Length != 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Record.LastName = LastName.Text;
            Record.FirstName = FirstName.Text;
            Record.SecondName = SecondName.Text;
            Record.Gender = Gender.Text;
            Record.Post = Post.Text;
            Record.WorkExperience = Convert.ToInt32(WorkExperience.Text);
            Record.Salary = Convert.ToInt32(Salary.Text);

            this.Close();
        }
    }
}
