namespace H25_3._5_Encapsulation.v1
{
    internal class TrafficLight
    {
        private bool _red;
        private bool _yellow;
        private bool _green;

        public TrafficLight()
        {
            _red = true;
        }

        public void Write()
        {
            TrafficLightConsole.Write(_red, _yellow, _green);
        }

        public void NextPhase()
        {
            if (_red && !_yellow)
            {
                _yellow = true;
            }
            else if (_red && _yellow)
            {
                _red = false;
                _yellow = false;
                _green = true;
            }
            else if (_green)
            {
                _yellow = true;
                _green = false;
            }
            else if (_yellow)
            {
                _yellow = false;
                _red = true;
            }
        }

    }
}
