namespace GameCar
{
    class FuelTank
    {
        public float Capacity { get; private set; }
        public float CurrentFuel { get; private set; }

        public FuelTank(float capacity)
        {
            Capacity = capacity;
            CurrentFuel = capacity;
        }

        public void Refuel(float amount)
        {
            CurrentFuel += amount;
            if (CurrentFuel > Capacity)
            {
                CurrentFuel = Capacity;
            }
            Console.WriteLine($"Refueled: {CurrentFuel}/{Capacity} L");
        }

        public bool ConsumeFuel(float amount)
        {
            if (CurrentFuel >= amount)
            {
                CurrentFuel -= amount;
                return true;
            }

            CurrentFuel = 0;
            Console.WriteLine("Fuel tank is empty!");
            return false;
        }
    }
}