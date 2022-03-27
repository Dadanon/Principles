using System;
using Principles.Abstraction.Level_1;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(carColor: Color.Red, carWeight: 2000);
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.AddGas();
            car1.ReduceGas();
            car1.ReduceGas();
            car1.getStats();
        }
    }
}
