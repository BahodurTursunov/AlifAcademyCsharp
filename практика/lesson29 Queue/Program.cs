using System.Collections;

namespace lesson29_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueStr = new Queue<string>(capacity: 100); // помогает избежать постоянного изменения размера коллекции при добавлении новых элементов

            queueStr.Enqueue("a");
            queueStr.Enqueue("b");
            queueStr.Enqueue("c");
            queueStr.Enqueue("c");

            string first = queueStr.Dequeue();
            string second = queueStr.Dequeue();
            string third = queueStr.Dequeue();
            string f = queueStr.Dequeue();

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(f);

            if (queueStr.TryDequeue(out string result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Queue is empty!");
            }

            Console.WriteLine("\n");

            Stack<string> stackStr = new Stack<string>(capacity: 100);
            stackStr.Push("a");
            stackStr.Push("b");
            stackStr.Push("c");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stackStr.Pop());
            }

            Console.WriteLine("\n");

            ArrayList arrayList = new ArrayList(capacity: 100)
            {
                "a",
                123,
                new { FirstName = "Assa" }
            };

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(10, "a");
            sortedList.Add(23, "b");
            sortedList.Add(-100, "c");
            sortedList.Add(-1, "в");

            foreach (var (key, value) in sortedList)
            {
                Console.WriteLine(key + " " + value);
            }
        }
    }
}
