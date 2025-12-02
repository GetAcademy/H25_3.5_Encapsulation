namespace H25_3._5_Encapsulation.v2
{
    internal class TrafficLight
    {
        private int _phase;

        public void Write()
        {
            var red = _phase < 2;
            var yellow = _phase is 1 or 3;
            //var yellow = _phase % 2 == 1;
            var green = _phase == 2;
            TrafficLightConsole.Write(red, yellow, green);
        }

        public void NextPhase()
        {
            _phase++;
            if (_phase == 4) _phase = 0;

            //_phase = (_phase + 1) % 4;
        }
    }
}
