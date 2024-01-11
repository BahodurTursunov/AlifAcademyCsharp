namespace Practice_HW17
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 90.9;
            car.StartEngine();
            Console.WriteLine($"Скорость автомобиля {car.Speed} км/ч");

            Console.WriteLine();

            Bicycle bicycle = new Bicycle();
            bicycle.Speed = 40.4;
            bicycle.StartEngine();
            Console.WriteLine($"Скорость велосипеда {bicycle.Speed} км/ч");

        }
    }
}
