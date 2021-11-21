using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _9
{
    internal class ViewModel
    {
        public IList<Worker> DataBase { get; set; }
    }
    public struct Worker
    {
        public Worker(
                string FirstName,
                string SecondName,
                string LastName,
                string Gender,
                string Post,
                int WorkExperieence,
                int Salary
                     )
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Gender = Gender;
            this.Post = Post;
            this.WorkExperience = WorkExperieence;
            this.Salary = Salary;
        }
        public Worker(int nugna)
        {
            FirstName = "И";
            SecondName = "О";
            LastName = "Ф";
            Gender = "М/Ж";
            Post = "важный";
            WorkExperience = 1000000;
            Salary = 1000000;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Post { get; set; }
        public int WorkExperience { get; set; }
        public int Salary { get; set; }
    }
    public partial class MainWindow : Window
    {
        //public ObservableCollection<Worker> workers = new ObservableCollection<Worker>();
        ViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ViewModel() { DataBase = new ObservableCollection<Worker>() };
            this.DataContext = _viewModel;
            _viewModel.DataBase.Add(new Worker(1));
        }
    }
}
