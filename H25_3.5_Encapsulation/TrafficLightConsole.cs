using System.Text;

namespace H25_3._5_Encapsulation
{
    internal class TrafficLightConsole
    {
        public static void Write(bool red, bool yellow, bool green)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            WriteLine(red ? ConsoleColor.Red : ConsoleColor.DarkGray);
            WriteLine(yellow ? ConsoleColor.Yellow : ConsoleColor.DarkGray);
            WriteLine(green ? ConsoleColor.Green : ConsoleColor.DarkGray);
            Console.WriteLine("┗━┛");
        }

        private static void WriteLine(ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("⬤");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┃");
        }
    }
}
