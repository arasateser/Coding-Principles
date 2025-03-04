using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sOlid : open/closed principle
//program should be open for extending and closed for modificating
//by creating interfaces and polymorphism we are allowing every payment method
//to work in their own space however they need to
//but declare the needs they should have


namespace codingPrinciples.SOLID.Models
{
    interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
