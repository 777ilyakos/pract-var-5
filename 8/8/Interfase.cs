using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    interface IComparable
    {
        int CompareTo(object obj);
    }
    interface ICloneable
    {
        Object Clone();
    }
    interface ISeries
    {
        int Next { get; }
        int GetNext();
        void Reset();
        void SetStsrt(int startValue);
    }
}
