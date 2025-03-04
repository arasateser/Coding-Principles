using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.KISS
{
    class foodOrder
    {
        //KISS: Keep It Stupid Simple
        //our goal is the make our code as simple as possible
        //in this example we assigned every size and their prices
        //prices only change with their size and they are static values
        //so we do not need different function for every size or
        //switch cases we can simply create a dictionary for this specific purpose
        private static readonly Dictionary<string, decimal> _sizePrices = new()
        {
            {"small",5 },
            {"mid",10 },
            {"big",12 }
        };

        public decimal CalculatePrice(string size)
        {
            return _sizePrices.TryGetValue(size.ToLower(), out decimal price)
                ? price
                : throw new ArgumentException("unavailable size");
        }
    }
}
