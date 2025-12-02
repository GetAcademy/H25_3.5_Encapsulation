using H25_3._5_Encapsulation.v1;

namespace H25_3._5_Encapsulation
{
    internal class Demo2
    {
        public static void Run()
        {
            var trafficLight = new TrafficLight();

            while (true)
            {
                Console.Clear();
                trafficLight.Write();
                trafficLight.NextPhase();
                Console.ReadKey(false);
            }
        }
    }
}
