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
        private Color color = Color.Black;
        private float weight = 1000;
        private float currentSpeed = 0;
        private float maxSpeed = 140;
        private float tankCapacity = 30;
        private float price = 10000;
        private int currentFuel = 10;
        private float money = 1000;

        public Car(Color carColor, float carWeight)
        {
            this.color = carColor;
            this.weight = carWeight;
        }

        public void AddGas()
        {
            if (this.currentFuel > 0)
            {
                if (this.currentSpeed < this.maxSpeed)
                {
                    this.currentSpeed += 20;
                    this.currentFuel -= 1;
                    this.money += 2;
                    Console.WriteLine("Your speed is " + this.currentSpeed + ".");

                    if (this.currentFuel > 5)
                    {
                        Console.WriteLine("You have now " + this.currentFuel + " fuel.");
                    } 
                    
                    else if (this.currentFuel > 0 & this.currentFuel <= 5)
                    {
                        Console.WriteLine("! You have only " + this.currentFuel + " fuel left !");
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
            if (this.currentSpeed >= 20)
            {
                this.currentSpeed -= 20;
                Console.WriteLine("Your speed is " + this.currentSpeed + ".");
            }

            else
            {
                Console.WriteLine("You have stopped.");
            }
        }

        public void FillTank()
        {
            if (this.currentFuel <= 20)
            {
                if (this.money >= 10)
                {
                    this.currentFuel += 10;
                    this.money -= 10;
                    Console.WriteLine("You have now " + this.currentFuel + " fuel.");
                    Console.WriteLine("You have now " + this.money + " money.");
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
            while (this.currentSpeed != 0)
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
            if (this.money >= 100)
            {
                this.money -= 100;
                this.color = value;
            }
        }


        public void TuneCar()
        {
            if (this.money >= 200)
            {
                this.tankCapacity += 10;
                this.maxSpeed += 20;
                this.money -= 200;
                Console.WriteLine("Your car tank capacity is " + this.tankCapacity + "!");
                Console.WriteLine("Your car maximal speed is " + this.maxSpeed + "!");
            }

            else
            {
                Console.WriteLine("You do not have enough money to tune!");
            }
        }


        public void getStats()
        {
            Console.WriteLine("Your car color is: " + this.color);
            Console.WriteLine("Your car weight is: " + this.weight);
            Console.WriteLine("Your car current speed is: " + this.currentSpeed);
            Console.WriteLine("Your car maximum speed is: " + this.maxSpeed);
            Console.WriteLine("Your car tank capacity is: " + this.tankCapacity);
            Console.WriteLine("Your car price is: " + this.price);
            Console.WriteLine("Your car current fuel is: " + this.currentFuel);
            Console.WriteLine("Your money is: " + this.money);

        }
    }
}
