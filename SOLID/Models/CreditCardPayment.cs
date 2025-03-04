using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID.Models

    //solId: INterface segragation principle
    //classes should not be forced to implement unused methods
    //insted of large interfaces, small and specific interfaces should be created
    //credit card payment supports refunds so it is safe to imlement refundable interface
    //but troy does not support refunds
{
    class CreditCardPayment : IPaymentMethod, IRefundable
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} TL using credit card");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refunded {amount} TL using credit card");
        }
    }
}
