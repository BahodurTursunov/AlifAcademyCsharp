using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace lesson12_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.DoStuff(5);
        }
    }

    partial class Person
    {
        public partial void DoStuff(int hours)
        {
            Console.WriteLine("Sleeping for " + hours + "hours.");
        }
    }

    partial class Person
    {
        public partial void DoStuff(int hours);
    }
}

/*
// consoleExtension.WriteTab();
// consoleExtension.WriteTab2();


ConsoleExtension.WriteTab();
ConsoleExtension.WriteTab2();
Console.Write("Hello!");
Console.WriteLine(ConsoleExtension.Number);

// B b = new();
// b.Number = 10;
// b.Do();

class ConsoleExtension
{
    public void WriteTab()
    {
        Console.Write("\t");
    }
}

class A
{
    public int Number { get; set; }
}

sealed class B : A
{
    void Do()
    {
    }
}

class C : B // ERROR! CS0509
{

}

static class ConsoleExtension
{
    public static int Number = 1000;
    
    public static void WriteTab()
    {
        Console.Write("\t");
    }
    
    public static void WriteTab2()
    {
        Console.Write("\t\t");   
    }
}
 */