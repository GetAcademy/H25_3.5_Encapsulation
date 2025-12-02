using H25_3._5_Encapsulation.GenericList;

namespace H25_3._5_Encapsulation
{
    internal class Demo7
    {
        public static void Run()
        {
            var list = new MyList<string>();

            while (true)
            {
                Console.Clear();
                list.Show();
                Console.Write("Skriv et tall: ");
                var word = Console.ReadLine();
                list.Add(word);
            }


            var list2 = new MyList<int>();

            while (true)
            {
                Console.Clear();
                list2.Show();
                Console.Write("Skriv et tall: ");
                var word = Console.ReadLine();
                var number = int.Parse(word);
                list2.Add(number);
            }
        }
    }
}
