using System;
using Principles.Abstraction.Level_1;
using Principles.Abstraction.Level_2;
using Principles.Generics;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<string> bob = new Person<string>("522", "Bob");
            Console.WriteLine(bob);
            Company<Person<string>> company = new Company<Person<string>>(bob);
            Console.WriteLine(company);

            Man<int> tom = new Man<int>(566, "Tom");
            Man<string>.code = "bulk";
            Man<int>.code = 15;
            Console.WriteLine(tom);

            Women<int, string> marfa = new Women<int, string>(509, "glupoe", "Marfa");
            Console.WriteLine(marfa);

            // Наконец мы можем использовать обобщенные методы,
            // принимающие значение неопределенного типа.
            Swap<int>(5, 3);

            void Swap<T>(T x, T y)
            {
                (x, y) = (y, x);
                Console.WriteLine($"x: {x}, y: {y}");
            }
            // Подобный обмен можно делать через кортежи (как тут),
            // можно через временную переменную, XOR.
        }
    }
}
