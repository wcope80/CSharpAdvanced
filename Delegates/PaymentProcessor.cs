using System;

namespace Delegates
{
    public class PaymentProcessor
    {
        public void Process(Payment payment, Action<Payment> paymentActions)
        {
            paymentActions(payment);
        }
    }

}
