using System;

namespace Events
{
    public class EmailService
    {
        public void OnPizzaBaked(object source, EventArgs args)
        {
            Console.WriteLine("Notifying Customer by Email.");
        }
    }
}