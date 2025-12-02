using System;

namespace H25_3._5_Encapsulation.SimpleList
{
    internal class MyList
    {
        private int[] _numbers;
        private int _index;

        public MyList()
        {
            _numbers = new int[4];
        }

        public void Add(int number)
        {
            if (_index >= _numbers.Length)
            {
                var newNumbers = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[_index] = number;
            _index++;
        }

        public void Show()
        {
            for (var i = 0; i < _numbers.Length; i++)
            {
                Console.WriteLine($"indeks {i} => {_numbers[i]}");
            }
        }
    }
}
