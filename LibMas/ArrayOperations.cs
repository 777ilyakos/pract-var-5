using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibMas
{
    public class ArrayOperations
    {
        private int[] _array;
        public ArrayOperations(int lenght)
        {
            _array = new int[lenght];
        }
        int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public void FillArray(int fillValue)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = fillValue;
            }
        }
        public void FillRandomValues(int minValue, int maxValue)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                _array[i] = randomNumber.Next(minValue, maxValue);
            }
        }
        public void ClearArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = 0;
            }
        }
        public void SaveArray(string path)
        {
            using (StreamWriter save = new StreamWriter(path))
            {
                save.WriteLine(_array.Length);
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    save.WriteLine(_array[i]);
                }
            }
        }
        public void OpenArray(string path)
        {
            using (StreamReader open = new StreamReader(path))
            {
                int arrayLenght = Convert.ToInt32(open.ReadLine());
                _array = new int[arrayLenght];
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    _array[i] = Convert.ToInt32(open.ReadLine());
                }
            }
        }
    }
}
