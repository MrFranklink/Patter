using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public interface IPaymentStrategy

    {

        void Pay(int amount);

    }

    public class PayPalPayment : IPaymentStrategy

    {
        public void Pay(int amount)

        {

            Console.WriteLine($"Paid {amount} using PayPal.");

        }

    }


    public class CreditCardPayment : IPaymentStrategy

    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }

    }


    public class PaymentContext

    {

        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)

        {

            _paymentStrategy = paymentStrategy;

        }

        public void Pay(int amount)

        {

            _paymentStrategy.Pay(amount);

        }

        internal class Strategy
        {

        }
    }
}
