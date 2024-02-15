using System.Collections.Concurrent;

namespace HW27_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем ConcurrentQueue для безопасного добавления и удаления элементов из разных потоков.
            var concurrentQueue = new ConcurrentQueue<int>();

            // Создаем ConcurrentDictionary для безопасного добавления, обновления и удаления элементов из разных потоков.
            var conncurentDictionary = new ConcurrentDictionary<int, string>();

            // Создаем CancellationTokenSource для отмены выполнения задачи.
            var cancellationTokenSource = new CancellationTokenSource();

            // Создаем и запускаем задачу, которая добавляет элементы в ConcurrentQueue.
            Task producerTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    concurrentQueue.Enqueue(i);
                    Console.WriteLine($"Added: {i}");
                    Thread.Sleep(100); // Имитируем задержку в производстве элементов.
                }
                cancellationTokenSource.Cancel();
            });

            // Создаем и запускаем задачу, которая обновляет ConcurrentDictionary.
            Task consumerTask = Task.Run(() =>
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested || !concurrentQueue.IsEmpty)
                {
                    if(concurrentQueue.TryDequeue(out int item)) Console.WriteLine($"Removed: {item}");
                    Thread.Sleep(200);
                }
            });

            try
            {
                Task.WaitAll(producerTask, consumerTask); // ждем завершения всех задач
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"An error occurred: {ex?.InnerException?.Message}");
            }

            finally
            {
                Console.WriteLine("Program is ended!!!");
            }
        }
    }
}
