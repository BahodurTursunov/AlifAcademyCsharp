using System.Collections.Generic;

namespace lesson27__коллекции__продолжение_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new() { "1salam", "1aleykum!" };

            List<string> list2 = ["2first", "2second", "2third"];

            List<string> list3 = new();
            //List<string> list4 = new(capacity: 10) ;
            //Console.WriteLine("Count:" + list3.Count);




            list3.Add("3First");

            list3.AddRange(list); // позволяет добавлять множество значений
            list3.AddRange(list2); // позволяет добавлять множество значений

            list3[0] = "3Hello";
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list3[2]);
        }
    }
}
