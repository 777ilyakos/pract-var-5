using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Equilateral : Triangle
    {
        public Equilateral():
            base()
        {
        }
        public Equilateral(int lenght) :
            base(lenght)
        {
        }
        new public bool TriangleCheck()
        {
            if (length1 == length2 && length2 == length3)
                return false;
            return true;
        }
        public static Equilateral operator ++(Equilateral triangle)
        {
            triangle.length1++;
            triangle.length2++;
            triangle.length3++;
            return triangle;
        }
        public static Equilateral operator --(Equilateral triangle)
        {
            triangle.length1--;
            triangle.length2--;
            triangle.length3--;
            return triangle;
        }
        public static bool operator true(Equilateral triangle)
        {
            if (triangle.length1 == triangle.length2 && triangle.length2 == triangle.length3)
                return false;
            return true;
        }
        public static bool operator false(Equilateral triangle)
        {
            if (triangle.length1 != triangle.length2 || triangle.length2 != triangle.length3)
                return false;
            return true;
        }
    }
}
