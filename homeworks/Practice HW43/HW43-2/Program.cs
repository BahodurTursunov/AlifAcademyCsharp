namespace HW43_2
{

    public class AsyncWithCancellation
    {
        public async Task<int> DoWorkAsync(int delay, CancellationToken cancellationToken)
        {
            await Task.Delay(delay, cancellationToken); // Асинхронная операция с отменой
                                                        // ...  Выполнение других задач ...

            return 42; // Возвращаемое значение
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationSource = new CancellationTokenSource();
            var token = cancellationSource.Token;

            var worker = new AsyncWithCancellation();
            var task = worker.DoWorkAsync(5000, token); // Запускаем асинхронную задачу

            // ...  Выполнение других задач ... 

            // Запрос отмены через 2 секунды
            await Task.Delay(2000);
            cancellationSource.Cancel();

            try
            {
                int result = await task;
                Console.WriteLine($"Результат: {result}");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция отменена.");
            }
        }
    }



}
