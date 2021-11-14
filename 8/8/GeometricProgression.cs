using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class GeometricProgression : ISeries, ICloneable, IComparable
    {
        public GeometricProgression()
        {
            _startValue = 0;
            _Value = _startValue;
            _multiplier = 0;
        }
        public GeometricProgression(int startValue)
        {
            _startValue = startValue;
            _Value = _startValue;
            _multiplier = 0;
        }
        public GeometricProgression(int startValue, int multiplier)
        {
            _startValue = startValue;
            _Value = _startValue;
            _multiplier = multiplier;
        }
        private int _startValue;
        private int _Value;
        private int _multiplier;

        public object Clone()
        {
            GeometricProgression new1 = new GeometricProgression(_startValue, _multiplier);
            new1._Value = _Value;
            return new1;
        }
        public int CompareTo(object geometricProgression)
        {
            GeometricProgression geomProgrs = (GeometricProgression)geometricProgression;
            if (_multiplier > geomProgrs._multiplier) return 1;
            if (_multiplier < geomProgrs._multiplier) return -1;
            return 0;
        }
        public int Next
        {
            get
            {
                _Value *= _multiplier;
                return _Value;
            }
        }
        public int GetNext()
        {
            return _Value * _multiplier;
        }
        public void Reset()
        {
            _Value = _startValue;
        }
        public void SetStart(int startValue)
        {
            _startValue = startValue;
        }
        public void SetMultiplier(int multiplier)
        {
            _multiplier = multiplier;
        }
    }
}
