namespace lesson11_properties_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new()
            {
                FirstName = "Test",
                LastName = "Debug"
            };

            Person person1 = person;
            person1.FirstName = "sad";
            Console.WriteLine($"FirstName: {person.FirstName}\t LastName: {person.LastName}");


            // МЕТОДЫ ДЛЯ ПРОВЕРКИ РАВЕНСТВА ССЫЛОК
            Console.WriteLine(person == person1);
            Console.WriteLine(person.Equals(person1));
            Console.WriteLine(object.ReferenceEquals(person, person1));

        }
    }
}
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        Console.WriteLine("Creating new person");
    }

    public void SetName(Person person)
    {
        person.FirstName = "Jack";
    }
}
