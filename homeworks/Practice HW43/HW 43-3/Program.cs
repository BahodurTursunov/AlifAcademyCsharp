namespace HW_43_3
{
    public class AsyncWithCancellation
    {
        public static async Task<int> DoWorkAsync(CancellationToken cancellationToken)
        {
            try
            {
                // Имитация длительной операции
                await Task.Delay(5000, cancellationToken);
                return 42; // Результат операции
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция отменена.");
                return -1; // Значение при отмене
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1; // Значение при ошибке
            }
        }

        public static async Task Main()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            // Запуск асинхронной операции
            var task = DoWorkAsync(token);

            // Запрос отмены через 2 секунды
            await Task.Delay(6000);
            cts.Cancel();

            try
            {
                var result = await task;
                Console.WriteLine($"Результат: {result}");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция отменена в Main.");
            }
        }
    }
}