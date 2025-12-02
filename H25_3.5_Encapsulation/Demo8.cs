using H25_3._5_Encapsulation.GenericList;

namespace H25_3._5_Encapsulation
{
    internal class Demo8
    {
        public static void Run()
        {
            var list = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(string.Join(',',list));
                Console.Write("Skriv et tall: ");
                var word = Console.ReadLine();
                list.Add(word);
            }


            var list2 = new List<int>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(string.Join(',', list2));
                Console.Write("Skriv et tall: ");
                var word = Console.ReadLine();
                var number = int.Parse(word);
                list2.Add(number);
            }
        }
    }
}
