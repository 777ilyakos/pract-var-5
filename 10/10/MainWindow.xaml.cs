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

namespace _10
{
    public partial class MainWindow : Window
    {
        private List<int> _array = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            listItem.ItemsSource = _array;

        }
        public void AddRandomIntInCollection(ICollection<int> collection, int count, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                collection.Add(random.Next(minValue, maxValue));
            }
        }
    }
}
