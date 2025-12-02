using H25_3._5_Encapsulation.SimpleList;

namespace H25_3._5_Encapsulation
{
    internal class Demo6
    {
        public static void Run()
        {
            var list = new List();

            while (true)
            {
                Console.Write("Skriv et tall: ");
                var numberStr = Console.ReadLine();
                var number = int.Parse(numberStr);
                list.Add(number);
                list.Show();
            }
        }
    }
}
