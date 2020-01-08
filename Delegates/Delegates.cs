using System;

namespace Delegates
{
    public class Delegates
    {
        public void ProcessPayment()
        {
            var payment = new Payment(){Total = 100, Tip = 10, Tax = 8, OverdueAmount = 30, Discount = 5 };
            PaymentProcessor processor = new PaymentProcessor();
            PaymentCalculator calculator = new PaymentCalculator();
            Action<Payment> paymentActions = calculator.AddTip;
            paymentActions += calculator.ApplyDiscount;
            if(payment.OverdueAmount > 0 )
                paymentActions += (p) => { p.Total += p.OverdueAmount; };
            paymentActions += calculator.AddTip;
            
            paymentActions += calculator.AddTax;
            processor.Process(payment, paymentActions);

        }  
        
    }
    
}
