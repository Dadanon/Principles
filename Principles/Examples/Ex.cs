using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.Examples
{
    class Ex
    {

    }

    class Person
    {
        public readonly string name;
        public static int RetAge = 60;
        public Person(string name)
        {
            this.name = name;
        }
        public string StoreName()
        {
            return name;
        }

        public void PrintUpper(string? str)
        {
            Console.WriteLine(str.ToUpper());
        }
    }
}
