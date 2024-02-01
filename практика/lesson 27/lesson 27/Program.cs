using System.Collections;
using System.Collections.Concurrent; // хранит в себе не обобщенные коллекции

namespace lesson_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. не обобщенные коллекции
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("hellow");
            
            Stack stack = new Stack();
            stack.Push(345);
            
            Queue queue = new Queue();
            queue.Enqueue("hello");

            // 2. Обобщенные коллекции
            List<int> ints = new List<int>();
            ints.Add('g');
            foreach (var item in ints)
            {
                Console.WriteLine($"int: {item}");
            }

            Dictionary<int, string> dictionary = new();
            dictionary.Add(1, "hello");

            Stack<int> ints2 = new Stack<int>();
            ints2.Push(2);

            Queue<string> strings = new Queue<string>();
            strings.Enqueue("hello");

            // 3. Concurrent Collection
            ConcurrentDictionary<int, string> concurrent = new();
            concurrent.TryAdd(1, "one");

            ConcurrentQueue<int> concurrentQueue = new();
            concurrentQueue.Enqueue(10);

            ConcurrentBag<int> concurrentBag = new();
            concurrentBag.Add(2);


        }
    }
}
