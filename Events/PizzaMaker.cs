using System;

namespace Events
{
    public class PizzaMaker
    {
        public delegate void PizzaBakedEventHandler(object source, EventArgs args);

        public event PizzaBakedEventHandler PizzaBaked;
        public void Bake(Pizza pizza)
        {
            Console.WriteLine("Baking Pizza");
            OnPizzaBaked();
        }

        protected virtual void OnPizzaBaked()
        {
            //PizzaBaked?.Invoke(this, EventArgs.Empty);
            if (PizzaBaked != null)
                PizzaBaked(this, EventArgs.Empty);
        }
    }
}