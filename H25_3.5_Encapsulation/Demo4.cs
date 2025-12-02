using H25_3._5_Encapsulation.v4;

namespace H25_3._5_Encapsulation
{
    internal class Demo4
    {
        public static void Run()
        {
            var trafficLight = new TrafficLight();
            var greenCount = 0;

            while (true)
            {
                Console.Clear();
                trafficLight.Write();
                //Console.WriteLine(trafficLight.Phase);
                //trafficLight.Phase = 5;
                //if (trafficLight.IsGreen()) greenCount++;
                if (trafficLight.IsGreen) greenCount++;
                Console.WriteLine($"Antall ganger grønt: {greenCount}");
                trafficLight.NextPhase();
                Console.ReadKey(false);
            }
        }
    }
}
