using System;
using System.Collections.Generic;
using System.Text;

namespace Principles.Abstraction.Level_1
{
    // 1st level of abstraction

    // Here I will create a Car class with detailed methods and fields.
    // But you can only create instances of Car class without possibility to create 
    // a class inherited from Car, no flexibility.
    public enum Color { Black, Blue, Green, Red, Yellow };
    class Car
    {
        protected Color color;
        protected float weight;
        protected float currentSpeed;
        protected float maxSpeed;
        protected float tankCapacity;
        protected float price;
        protected int currentFuel;
        protected float money;

        public Car()
        {
            color = Color.Black;
            weight = 1000;
            currentSpeed = 0;
            maxSpeed = 140;
            tankCapacity = 30;
            price = 10000;
            currentFuel = 10;
            money = 1000;
        }
        public void AddGas()
        {
            if (currentFuel > 0)
            {
                if (currentSpeed < maxSpeed)
                {
                    currentSpeed += 20;
                    currentFuel -= 1;
                    money += 2;
                    Console.WriteLine("Your speed is " + currentSpeed + ".");
                    Console.WriteLine("Your money is " + money + ".");

                    if (currentFuel > 5)
                    {
                        Console.WriteLine("You have now " + currentFuel + " fuel.");
                    } 
                    
                    else if (currentFuel > 0 & currentFuel <= 5)
                    {
                        Console.WriteLine("! You have only " + currentFuel + " fuel left !");
                    }
                }

                else
                {
                    Console.WriteLine("You are out of speed!!!");
                }
            }

            else
            {
                Console.WriteLine("! You are out of fuel !");
            }
        }

        public void ReduceGas()
        {
            if (currentSpeed >= 20)
            {
                currentSpeed -= 20;
                Console.WriteLine("Your speed is " + currentSpeed + ".");
            }

            else
            {
                Console.WriteLine("You have stopped.");
            }
        }

        public void FillTank()
        {
            if (currentFuel <= 20)
            {
                if (money >= 10)
                {
                    currentFuel += 10;
                    money -= 10;
                    Console.WriteLine("You have now " + currentFuel + " fuel.");
                    Console.WriteLine("You have now " + money + " money.");
                }

                else
                {
                    Console.WriteLine("You do not have enough money to fill in.");
                }
            }

            else
            {
                Console.WriteLine("You have enough fuel.");
            }
        }


        public void Stop()
        {
            while (currentSpeed != 0)
            {
                ReduceGas();
            }
        }


        public void Beep()
        {
            Console.WriteLine("BE-BE-BEEEEEP!");
        }


        public void ChangeColor(Color value)
        {
            if (money >= 100)
            {
                money -= 100;
                color = value;
            }
        }


        public void TuneCar()
        {
            if (money >= 200)
            {
                tankCapacity += 10;
                maxSpeed += 20;
                money -= 200;
                Console.WriteLine("Your car tank capacity is " + tankCapacity + "!");
                Console.WriteLine("Your car maximal speed is " + maxSpeed + "!");
            }

            else
            {
                Console.WriteLine("You do not have enough money to tune!");
            }
        }


        public void GetStats()
        {
            Console.WriteLine("Your car color is: " + color);
            Console.WriteLine("Your car weight is: " + weight);
            Console.WriteLine("Your car current speed is: " + currentSpeed);
            Console.WriteLine("Your car maximum speed is: " + maxSpeed);
            Console.WriteLine("Your car tank capacity is: " + tankCapacity);
            Console.WriteLine("Your car price is: " + price);
            Console.WriteLine("Your car current fuel is: " + currentFuel);
            Console.WriteLine("Your car money is: " + money);
        }
    }
}
