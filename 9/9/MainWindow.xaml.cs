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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEntry blank = new AddEntry(default);
            blank.ShowDialog();
            _viewModel.DataBase.Add(blank.Record);
        }
    }
}
