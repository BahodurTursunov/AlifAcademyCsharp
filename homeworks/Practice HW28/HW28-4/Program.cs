namespace HW28_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Bakha");
            queue.Enqueue("Islam");
            queue.Enqueue("Amriddin");
            queue.Enqueue("Murodjon");
            queue.Enqueue("Azimjon");

            Console.WriteLine("Исходная очередь");
            DisplayInfo(queue);
            Console.WriteLine();

            while (queue.Count > 0)
            {
                Console.WriteLine("Очередь после обслуживания клиента -> " + queue.Peek());
                queue.Dequeue();
                DisplayInfo(queue);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Очередь пуста");
        }

        static void DisplayInfo(Queue<string> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
