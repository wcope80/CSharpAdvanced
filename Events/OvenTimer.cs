using System;

namespace Events
{
    public class OvenTimer
    {
        public void OnPizzaBaked(object source, EventArgs args)
        {
            Console.WriteLine("Alerting pizza cooks.");
        }
    }
}