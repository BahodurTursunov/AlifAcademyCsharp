//Interface
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace lesson17
{   
    interface IEquatable
    {
        bool Equals(object obj);
    }
    interface ILogger
    {
        public void Log(string message);

        public void LogToConsole(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        public void LogToFile(string message)
        {
            System.IO.File.AppendAllText("log.txt", message);
        }
    }

    public sealed class Person : IEquatable
    {
        public string FirstName { get; set; }

        public bool Equals(object obj)
        {
            Person person = (Person)obj;
            return string.Equals(FirstName, person.FirstName);
        }
    }

    public sealed class User : IEquatable
    {
        public bool Equals(object obj)
        {
            throw new Exception();
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging message into console output");
            LogToConsole(message);
        }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            //Person person = new() { FirstName = "Bob" };
            //Person person2 = new() { FirstName = "John" };
            //bool isEquals = person.Equals(person2);
            //Console.WriteLine(isEquals);
            ConsoleLogger consoleLogger = new ("");

        }
    }
}
