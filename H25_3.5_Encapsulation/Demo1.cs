namespace H25_3._5_Encapsulation
{
    internal class Demo1
    {
        public static void Run()
        {
            var red = true;
            var yellow = false;
            var green = false;

            while (true)
            {
                Console.Clear();
                TrafficLightConsole.Write(red, yellow, green);

                if (red && !yellow)
                {
                    yellow = true;
                }
                else if (red && yellow)
                {
                    red = false;
                    yellow = false;
                    green = true;
                }
                else if (green)
                {
                    yellow = true;
                    green = false;
                }
                else if (yellow)
                {
                    yellow = false;
                    red = true;
                }

                Console.ReadKey(false);
            }
        }
    }
}
