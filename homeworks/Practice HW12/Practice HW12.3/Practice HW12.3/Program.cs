using System.Globalization;

namespace Practice_HW12._3
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }

    }

    public sealed class Dog : Animal
    {
        public Dog(string name, string makeSound) : base(name) {}
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new
        }
    }
}
