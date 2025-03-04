using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.DRY
{
    class CarRentalService
    {
        //DRY: Don't Repeat Yourself Principle
        //avoid duplicating your code
        //we are calculating price of multiple cars in our program
        //but the formula is always the same
        //so there is no need for different calculations for each car(it would have been a bad use od DRY)
        //to avoid that we can create a single calculation formula and
        //send details of each car whenever we need to

        public decimal CalculatePrice(int days, decimal dailyRate)
        {
            decimal total = days * dailyRate;
            if (days > 7) total *= 0.9m;
            return total;
        }
    }
}
