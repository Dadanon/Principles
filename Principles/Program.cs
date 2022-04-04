using System;
using Principles.Abstraction.Level_1;
// using Principles.Abstraction.Level_2;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck(2, 1.1m);
            Console.WriteLine($"Грузовик с грузоподъемностью {truck.Capacity} тонн");
        }
    }

    class Auto  // легковой автомобиль
    {
        public int Seats { get; set; } // количество сидений
        public Auto(int seats)
        {
            Seats = seats;
        }

        public Auto()
        {
        }
    }
    class Truck : Auto      // грузовой автомобиль
    {
        public decimal Capacity { get; set; } // грузоподъемность
        public Truck(int seats, decimal capacity)
        {
            Seats = seats;
            Capacity = capacity;
        }
    }
}
