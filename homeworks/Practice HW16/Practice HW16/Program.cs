using System.Drawing;

namespace Practice_HW16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new("Leo", 10, "Orange");
            lion.DisplayInfo();
            Console.WriteLine();
            Elephant elephant = new("Jack", 50, 1.7);
            elephant.DisplayInfo();
        }
    }

    public abstract class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();

        public virtual void DisplayInfo()
        {
            Console.Write($"Name {Name}, Age {Age}");
            MakeSound();
        }
    }

    public class Lion : Animal
    {
        public string? ManeColor { get; set; }

        public Lion(string name, int age, string maneColor) : base(name, age)
        {
            ManeColor = maneColor;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Sound: Roar");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.Write($"Mane Color {ManeColor}");
        }
    }

    public class Elephant : Animal
    {
        public double TrunkLenght { get; set; }

        public Elephant(string name, int age, double trunkLength) : base(name,age)
        {
            TrunkLenght = trunkLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Trump trump");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Trunket Length {TrunkLenght} meters");
        }
    }
}
