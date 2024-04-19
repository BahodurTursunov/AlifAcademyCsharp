namespace Практическое_применение_многопоточности
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
            Task task2 = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }); 
            Task task3 = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }); 
            Task task4 = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }); 
            Task task5 = Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });

            await task1;
            await task2;
            await task3;
            await task4;
            await task5;
        }
    }
}
