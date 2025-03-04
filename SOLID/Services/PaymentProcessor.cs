using codingPrinciples.SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID.Services
{
    //Solid: Single Responsibility Principle
    //Evey class have only one reason to change.
    //PaymentProcessor handles only payment processing

    //soliD: Dependency Inversion Principle
    // high level modules should depend on abstraction isnted of concrete classes
    //we call it dependency injection
    //and we are injecting payment methods into payment processor
    //so we can use an existing method in another part of code which is payment processor

    class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;
         
        //injectiong
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.Pay(amount);
            TransactionLogger.LogTransaction(amount);
        }
    }
}
