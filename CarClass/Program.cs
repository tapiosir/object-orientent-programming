using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(null, 0);
            Car car1 = new Car(null, 0);
            car.AskData();
            car1.AskData();
            Console.WriteLine(car.ShowCarInfo());
            Console.WriteLine(car1.ShowCarInfo());
            car.Accelerate();
            car1.Accelerate();
            Console.WriteLine(car.ShowCarInfo());
            Console.WriteLine(car1.ShowCarInfo());
            car.Brake();
            car1.Brake();
        }
    }
}
