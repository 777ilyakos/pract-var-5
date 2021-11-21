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

namespace _9
{
    struct Student
    {
        public string firstName;
        public string secondName;
        public string lastName;
        public Genders gender;
        public int workExperieence;
        public int salary;
        Student(string  FirstName       ,
                string  SecondName      ,
                string  LastName        ,
                Genders Gender          ,
                int     WorkExperieence ,
                int     Salary          )
        {
             firstName=        FirstName       ;
             secondName =      SecondName      ;
             lastName=         LastName        ;
             gender=           Gender          ;
             workExperieence=  WorkExperieence ;
            salary = Salary;
        }
    }
    enum Genders
    {
        Man,
        Woman
    }
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
