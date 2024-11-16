using System;

namespace GameCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("V8", 450);
            FuelTank fuelTank = new FuelTank(60);
            
            Car myCar = new Car("Ford", "Mustang", 2024, engine, fuelTank);
            
            Console.WriteLine(myCar);

            myCar.Start();
            myCar.Drive(500);
            Console.WriteLine(myCar);

            myCar.Drive(200);
            Console.WriteLine(myCar);

            myCar.Stop();
        }
    }
}