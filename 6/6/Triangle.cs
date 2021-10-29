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

namespace _6
{
    class Triangle
    {
        public Triangle() { }
        public Triangle(int lengths)
        {
            length1 = lengths;
            length2 = lengths;
            length3 = lengths;
        }
        public int length1 { get; set; }
        public int length2 { get; set; }
        public int length3 { get; set; }

        public void SetParams(int setLength1, int setLength2, int setLength3)
        {
            length1 = setLength1;
            length2 = setLength2;
            length3 = setLength3;
        }
        //public bool TriangleExist(this Triangle thisTriangle)
        //{
        //    if (thisTriangle.length1 + thisTriangle.length2 <= thisTriangle.length3)
        //        return false;
        //    if (thisTriangle.length1 + thisTriangle.length3 <= thisTriangle.length2)
        //        return false;
        //    if (thisTriangle.length3 + thisTriangle.length2 <= thisTriangle.length1)
        //        return false;
        //    return true;
        //}
        public bool TriangleCheck()
        {
            if (length1 + length2 <= length3)
                return false;
            if (length1 + length3 <= length2)
                return false;
            if (length3 + length2 <= length1)
                return false;
            return true;
        }
        public void IncreaseLengths(int multiplier)
        {
            length1 *= multiplier;
            length2 *= multiplier;
            length3 *= multiplier;
        }
        public void IncreaseLengths()
        {
            length1 *= 2;
            length2 *= 2;
            length3 *= 2;
        }
    }
}
