namespace Events
{
    public class EventMain
    {
        public void Main()
        {
            var pizzaMaker = new PizzaMaker();
            var pizza = new Pizza();
            var emailService = new EmailService();
            var ovenTimer = new OvenTimer();

            pizzaMaker.PizzaBaked += ovenTimer.OnPizzaBaked;
            pizzaMaker.PizzaBaked += emailService.OnPizzaBaked;            

            pizzaMaker.PizzaBaked += (s, e) => {System.Console.WriteLine("Boxing Pizza");};
            pizzaMaker.Bake(pizza);

               
        }

        
    }
}
