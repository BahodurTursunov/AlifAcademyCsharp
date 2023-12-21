using System.Xml.Serialization;

namespace lesson12_class_
{
    internal class Program
    {
        //    static void Main(string[] args)
        //    {
        //        Person person = new Person();
        //        person.DoStuff(5);
        //    }
        //}

        //partial class Person
        //{
        //    public partial void DoStuff(int hours)
        //    {
        //        Console.WriteLine("Sleeping for " + hours + "hours.");
        //    }
        //}

        //partial class Person
        //{
        //    public partial void DoStuff(int hours);
        //}

        static void Main(string[] args)
        {
            Person person = new Person(); // в этой части мы создали экземпляр класса Person
            person.Print(); // а тут мы вызвали у этого экземпляра метод Print
        }
        class Person // мы создали класс Person и добавили поля и методы описывающие данный класс.
        {
            public string Name = "Tom";
            public int Age = 22;
            public void Print()
            {
                Console.WriteLine($"Name: {Name} Age: {Age}");
            }
        }
    }
}
