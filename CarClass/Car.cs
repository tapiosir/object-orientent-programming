using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class Car
    {
        public string brand;
        public double speed;
        private readonly string skippy = "--------------------------------";
        Random speedGenerator = new Random();

        public Car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public void AskData()
        {
            brand = AskBrand();
            speed = AskSpeed();
        }
        public string ShowCarInfo()
        {
            return $" Brand: {brand}\n Speed: {speed} km/h \n{skippy}";
        }

        public void Accelerate()
        {
            speed = AskSpeed() + speed;
        }

        public void Brake()
        {
            speed = speed * 0.9;
            Console.WriteLine($"{brand} braked. Speed is now {speed}\n{skippy}");
        }
        private string AskBrand()
        {
            Console.WriteLine("What kind of car you want today:");
            return  Console.ReadLine();
        }

        private double AskSpeed()
        {
            Console.WriteLine($"input some speed for car {brand}:");
            string userInput = Console.ReadLine();
            bool isValid = double.TryParse(userInput, out double speedInput);
            if (isValid & speedInput > 0)
            {
               Console.WriteLine(skippy);
               return speedInput;   
            }
            else
            {
                Console.WriteLine("what were you trying to do? rng god decides your speed now.");
                Console.WriteLine(skippy);
                return speedGenerator.Next(0, 200);
            }
        }

    }
}
