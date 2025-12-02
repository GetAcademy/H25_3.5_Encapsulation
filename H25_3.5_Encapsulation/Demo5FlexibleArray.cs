namespace H25_3._5_Encapsulation
{
    internal class Demo5FlexibleArray
    {
        public static void Run()
        {
            int[] numbers = new int[4];
            var index = 0;

            while (true)
            {
                Console.Write("Skriv et tall: ");
                var numberStr = Console.ReadLine();
                var number = int.Parse(numberStr);
                if (index >= numbers.Length)
                {
                    var newNumbers = new int[numbers.Length*2];
                    Array.Copy(numbers, newNumbers, numbers.Length);
                    numbers = newNumbers;
                }
                numbers[index] = number;
                index++;

                for (var i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"indeks {i} => {numbers[i]}");
                }
            }
        }
    }
}
