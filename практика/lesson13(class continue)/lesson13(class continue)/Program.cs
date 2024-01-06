namespace lesson13_class_continue_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new
            {
                FirstName = "John",
                LastName = "Brown",
                Age = 55
            };
            var person1 = new
            {
                FirstName = "John",
                LastName = "Brown",
                Age = 55
            };

            var car = new { Name = "Tesla Model X", MaxSpeed = 300 };

            var car2 = car with { Name = "Mers" };// здесь выводится Mers и car.MaxSpeed как параметр

            Console.WriteLine(car2);
            var anArray = new[]
            {
                new { Name = "Tesla Model X", MaxSpeed = 300 },
                new { Name = "Tesla Model Y", MaxSpeed = 320 }
            };

            Console.WriteLine(person.Equals(person1));
            Console.WriteLine(object.ReferenceEquals(person, person1));
            Console.WriteLine(person == person1);
            Console.WriteLine(person.FirstName);
            Console.WriteLine("\n\n");

            (double, double, int) t1 = (10.5, 9.5, 100);
            (int A, int B) t2 = (200, 400);

            Console.WriteLine(t1.Item3);
            Console.WriteLine(t2.A);


        }

    }
}
