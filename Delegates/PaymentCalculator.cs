using System;

namespace Delegates
{
    public class PaymentCalculator
    {
        public void AddTax(Payment payment)
        {
            payment.Total += payment.Tax;
        }
        
        public void ApplyDiscount(Payment payment)
        {
            payment.Total -= payment.Discount;
        }

        public void AddTip(Payment payment)
        {
            payment.Total += payment.Tip;            
        }

    }

}
