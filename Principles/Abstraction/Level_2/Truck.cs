using System;
using System.Collections.Generic;
using System.Text;
using Principles.Abstraction.Level_1;

namespace Principles.Abstraction.Level_2
{
    // 2nd level of abstraction

    // Here I will create classes inherited from Car so
    // you can customize a little car models.
    class Truck : Car
    {
        private int loadCapacity;
        public Truck()
        {
            color = Color.Green;
            weight = 3000;
            currentSpeed = 0;
            maxSpeed = 100;
            tankCapacity = 50;
            price = 15000;
            currentFuel = 20;
            money = 1000;
            loadCapacity = 3000;
        }
        public void getStats()
        {
            base.GetStats();
            Console.WriteLine("Your car tank capacity is: " + loadCapacity);
        }
    }
}
