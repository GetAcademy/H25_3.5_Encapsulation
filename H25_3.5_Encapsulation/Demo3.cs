using H25_3._5_Encapsulation.v2;

namespace H25_3._5_Encapsulation
{
    internal class Demo3
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
                //trafficLight._green = true;
            }
        }
    }
}
