using System;
using Principles.Abstraction.Level_1;
using Principles.Abstraction.Level_2;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            truck.GetStats();
            Console.WriteLine("");
            Car car = new Car();
            car.GetStats();
        }
    }
}
