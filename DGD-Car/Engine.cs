namespace GameCar
{
    class Engine
    {
        public string Type { get; private set; } 
        public int HorsePower { get; private set; }
        public bool IsRunning { get; private set; }

        public Engine(string type, int horsePower)
        {
            Type = type;
            HorsePower = horsePower;
            IsRunning = false;
        }

        public void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("Engine started.");
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("Engine stopped.");
            }
        }
    }
}