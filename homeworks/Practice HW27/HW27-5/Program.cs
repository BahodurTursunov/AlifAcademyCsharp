using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace HW27_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5, 6];

            int elementToFind = 5;

            int index = IndexOf(list, elementToFind);

            if(index != -1) Console.WriteLine($"Элемент {elementToFind} найден по индексу {index}");

            bool contains = Contains(list, elementToFind);
            if(contains) Console.WriteLine($"Элемент {elementToFind} найден");
        }

        static int IndexOf(IList list, object element) => list.IndexOf(element);

        static bool Contains(IList list, object element) => list.Contains(element);
        
    }
}