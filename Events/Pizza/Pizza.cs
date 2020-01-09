using System;

namespace Events
{
    public class Pizza
    {
        public Ingredient<Cheese> PizzaCheese { get; set; }
        public Ingredient<Pepporoni> PizzaPepporoni { get; set; }
        public Ingredient<Sauce> PizzaSauce { get; set; }
       
        public void SetCheese(int amount)
        {
            PizzaCheese.Amount = amount;
        }
        
        public void SetPepporoni(int amount)
        {
            PizzaPepporoni.Amount = amount;
        }
        
        public void SetSauce(int amount)
        {
            PizzaSauce.Amount = amount;
        }
        
        
    }
}