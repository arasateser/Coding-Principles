using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.Law_of_Demeter
{
    //Law of Demeter: Don't Talk to Strangers
    //cashier in this shop has direct access inside of the coffe machine 
    //which is not ideal
    //cashier should only interact with barista not coffe machine
    class CoffeeMachine
    {
        public void BrewCoffee() => Console.WriteLine("Brewing coffee...");
    }

    class Barista
    {
        public CoffeeMachine Machine { get; } = new CoffeeMachine();
    }

    class Cashier
    {
        private readonly Barista _barista;

        public Cashier(Barista barista)
        {
            _barista = barista;
        }

        public void TakeOrder()
        {
            _barista.Machine.BrewCoffee();
        }
    }
}
