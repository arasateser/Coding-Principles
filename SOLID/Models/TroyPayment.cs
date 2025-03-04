using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID.Models
{
    //solId: INterface segragation principle
    //classes should not be forced to implement unused methods
    //insted of large interfaces, small and specific interfaces should be created
    //troy doesn not support refunds so I should not implement refund interface
    //but credit card payments support refunds
    class TroyPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} TL using Tory");
        }
    }
}
