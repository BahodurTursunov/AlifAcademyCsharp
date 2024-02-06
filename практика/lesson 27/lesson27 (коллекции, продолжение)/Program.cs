using System.Collections.Generic;

namespace lesson27__коллекции__продолжение_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> _dictionary = new();
            _dictionary.Add("+992928650046", "Bakha");
            _dictionary.Add("+992928650146", "Qakha");
            _dictionary.Add("+992928650246", "Wakha");
            _dictionary.Add("+992928650346", "Eakha");
            _dictionary.Add("+992928650446", "Rakha");

            bool isContains = _dictionary.ContainsKey("+992928650046");

            bool isExist = _dictionary.TryGetValue("+992968956632", out string customerName);
            Console.WriteLine(customerName + " : " + isExist);

            Console.WriteLine("\n\n\n");

            MyList<int> intList = new MyList<int>();
            intList.Add(100);
            intList.Add(100);
            intList.Add(100);
            intList.Add(100);
            intList.Add(100);

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }








            List<string> list = new() { "1salam", "1aleykum!" };

            List<string> list2 = ["2first", "2second", "2third"];

            List<string> list3 = new(capacity: 10);
            Console.WriteLine("Count:" + list3.Count);
            Console.WriteLine("Count:" + list3.Capacity);
            Console.WriteLine("\n\n\n\n\n");
            list3.AddRange(list);
            list3.AddRange(list2);
            list3.AddRange(list2);
            list3.AddRange(list);
            list3.AddRange(list2);
            list3.AddRange(list2);
            list3.AddRange(list2);
            list3.AddRange(list2);

            //List<string> list4 = new(capacity: 10) ;
            //Console.WriteLine("Count:" + list3.Count);

            list3.Add("3First");

            list3.AddRange(list); // позволяет добавлять множество значений
            list3.AddRange(list2); // позволяет добавлять множество значений

            list3[0] = "3Hello";

            Console.WriteLine("Count:" + list3.Count);
            Console.WriteLine("Count:" + list3.Capacity);


            
        }
    }
}
