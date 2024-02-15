using System.Collections.Generic;
namespace Practice_HW27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> items = new();
            items.Add("Hello");
            items.Add(1090);
            items.Add(3.14);
            items.Add(true);

            Console.WriteLine("Элементы коллекции:");

            foreach (object item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
