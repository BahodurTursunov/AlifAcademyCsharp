namespace Attributes
{
    /*что такое атрибут?
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new("Tom", 20);
            Person bob = new("Bob", 17);
            bool tomIsValid = ValidateUser(tom);
            bool bobIsValid = ValidateUser(bob);
            Console.WriteLine($"{tomIsValid}");
            Console.WriteLine($"{bobIsValid}");
        }

        static bool ValidateUser(Person person)
        {
            Type type = typeof(Person);

            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {

                if (attribute is AgeValidationAttribute ageAttrbute)
                {
                    return person.Age >= ageAttrbute.Age;
                }
            }
            return true;
        }
    }

    class AgeValidationAttribute : Attribute
    {
        public int Age { get; set; }
        public AgeValidationAttribute() { }
        public AgeValidationAttribute(int age) => Age = age;
    }

    [AgeValidationAttribute(18)]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }



}
