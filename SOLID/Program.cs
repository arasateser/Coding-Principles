using codingPrinciples.SOLID.Models;
using codingPrinciples.SOLID.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID
{
    //soLid: Liskov Substitution Principle
    //subtypes must be replaceable for their base type
    //if customers decides to pay with another payment method
    //it should be possible without complicationg the code
    //each payment methode should handele its procces without extra needs
    
    //PaymentProcessor does not care which payment method is being sent to it/
    //Thanks to this method we can swap any payment method in it
    class Program
    {
        static void Main()
        {
            IPaymentMethod payment = new TroyPayment();
            PaymentProcessor processor = new PaymentProcessor(payment);
            processor.ProcessPayment(200);
        }
    }
}
