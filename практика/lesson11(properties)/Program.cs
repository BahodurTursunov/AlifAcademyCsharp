//namespace lesson11_properties_
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new()
//            {
//                FirstName = "Test",
//                LastName = "Debug"
//            };

//            Person person1 = person;
//            person1.FirstName = "sad";
//            Console.WriteLine($"FirstName: {person.FirstName}\t LastName: {person.LastName}");


//            МЕТОДЫ ДЛЯ ПРОВЕРКИ РАВЕНСТВА ССЫЛОК
//            Console.WriteLine(person == person1);
//            Console.WriteLine(person.Equals(person1));
//            Console.WriteLine(object.ReferenceEquals(person, person1));

//        }
//    }
//}
//public class Person
//{
//    public string FirstName { get; init; }
//    public string LastName { get; set; }

//    public Person()
//    {
//        Console.WriteLine("Creating new person");
//    }

//    public void SetName(Person person)
//    {
//        person.FirstName = "Jack";


//    }
//}


//Robot robot = new Robot();
//robot.Print();
//(robot as Robot).Print();
//(robot as BaseRobot).Print();

//public abstract class BaseRobot
//{
//    public void Print() => Console.WriteLine("BaseRobot");
//}

//public class Robot : BaseRobot
//{
//    public new void Print() => Console.WriteLine("Robot");
//}


//Queue<string> queue = new Queue<string>();
//queue.Enqueue("1");
//queue.Enqueue("2");
//queue.Dequeue();
//queue.Enqueue("3");

//foreach (string item in (IEnumerable<string>)queue)
//{
//    Console.WriteLine(item);
//}

//Container container = new Container() { Value = 1 };
//Container.Nullify(container);
//Console.WriteLine(container.Value);

//public struct Container
//{
//    public int Value;
//    public static void Nullify(Container container) => container.Value = 0;
//}


List<int> numbers = new List<int> { 1, 2, 3, 4 };
IEnumerable<int> squares = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 2);

foreach (var square in squares)
{
    Console.WriteLine(square);
}