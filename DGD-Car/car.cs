using System;

namespace GameCar
{
    class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Engine CarEngine { get; private set; }
        public FuelTank CarFuelTank { get; private set; }

        public Car(string make, string model, int year, Engine engine, FuelTank fuelTank)
        {
            Make = make;
            Model = model;
            Year = year;
            CarEngine = engine;
            CarFuelTank = fuelTank;
        }

        public void Start()
        {
            if (CarFuelTank.CurrentFuel > 0)
            {
                CarEngine.Start();
            }
            else
            {
                Console.WriteLine("Cannot start the car. Fuel tank is empty.");
            }
        }

        public void Drive(float distance)
        {
            if (CarEngine.IsRunning && CarFuelTank.ConsumeFuel(distance * 0.1f))
            {
                Console.WriteLine($"Car drove {distance} km.");
            }
            else
            {
                Console.WriteLine("Cannot drive. Check engine or fuel.");
            }
        }

        public void Stop()
        {
            CarEngine.Stop();
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} - Engine: {CarEngine.Type}, Fuel: {CarFuelTank.CurrentFuel}/{CarFuelTank.Capacity} L";
        }
    }
}