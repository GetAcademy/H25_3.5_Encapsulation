namespace H25_3._5_Encapsulation.GenericList
{
    internal class MyList<T>
    {
        private T[] _numbers;
        private int _index;

        public MyList()
        {
            _numbers = new T[4];
        }

        public void Add(T value)
        {
            if (_index >= _numbers.Length)
            {
                var newNumbers = new T[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[_index] = value;
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
