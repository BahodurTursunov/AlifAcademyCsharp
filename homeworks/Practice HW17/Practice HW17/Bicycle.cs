namespace Practice_HW17
{
    internal class Bicycle : IVehicle
    {
        public double Speed { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Двигатель велосипеда запущен");
        }

    }
}
