using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.KISS
{
    class Program
    {
        public void Main()
        {
            foodOrder foodOrder = new foodOrder();

            string size = Console.ReadLine()?.ToLower();

            if (foodOrder.CalculatePrice(size) is decimal price)
            {
                Console.WriteLine($"food price is {price} for {size}");
            }
            else
            {
                Console.WriteLine("unavailable size");
            }
        }
    }
}
