using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingPrinciples.Composition_Over_Inheritance
{
    //Composition Over Inheritance
    //using objects inside a class over using class hierarchies when possible
    //another class might need similar thing from a class already using but
    //but if not created for the same goal they might conflict in the future
    //insted inheriting for faster coding better create objects that those classes need
    class Vehicle
    {
        public void Move() => Console.WriteLine("Moving...");
    }

    class Car : Vehicle
    {
        public void StartEngine() => Console.WriteLine("Starting engine...");
    }

    class Bicycle : Vehicle
    {
        public void Pedal() => Console.WriteLine("Pedaling...");
    }

}
