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
using System.Text.RegularExpressions;

namespace _11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string s1 = "aa aba abba abbba abca abea";
            Regex regex1 = new Regex(@"ab{0,}a");
            MatchCollection matchs1 = regex1.Matches(s1);
            StringBuilder oneString1 = new StringBuilder();
            for (int i = 0; i < matchs1.Count; i++)
            {
                oneString1.AppendLine(matchs1[i].Value.ToString());
            }
            MessageBox.Show(oneString1.ToString());



            string s2 = "a1a a2a a3a a4a a5a aba aca";
            Regex regex2 = new Regex(@"a[0-9]a");
            MatchCollection matchs2 = regex2.Matches(s2);
            StringBuilder oneString2 = new StringBuilder();
            for (int i = 0; i < matchs2.Count; i++)
            {
                oneString2.AppendLine(matchs2[i].Value.ToString());
            }
            MessageBox.Show(oneString2.ToString());


            this.Close();
        }
    }
}
