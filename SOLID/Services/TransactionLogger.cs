using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.SOLID.Services
{
    //Solid: Single Responsibility Principle
    //Evey class have only one reason to change.
    //TransactionLogger handles only logging transactions
    class TransactionLogger
    {
        internal static void LogTransaction(decimal amount)
        {
            Console.WriteLine($"Transaction logged as {amount} TL");
        }
    }
}
