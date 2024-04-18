using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Создаем объект класса AsyncWithCancellation
        var asyncOperation = new AsyncWithCancellation();

        // Создаем токен отмены
        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        // Запускаем асинхронную операцию
        Console.WriteLine("Запуск асинхронной операции...");
        var task = asyncOperation.DoSomethingAsync(10, cancellationToken);

        // Ждем завершения задачи
        try
        {
            var result = await task;
            Console.WriteLine($"Результат: {result}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Операция отменена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

public class AsyncWithCancellation
{
    public Task<int> DoSomethingAsync(int input, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            try
            {
                // Имитация длительной операции
                Thread.Sleep(2000);

                // Проверка на отмену
                cancellationToken.ThrowIfCancellationRequested();

                // Вычисление результата
                return input * 2;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Операция отменена.");
                return -1; // Или другое значение, указывающее на отмену
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1; // Или другое значение, указывающее на ошибку
            }
        }, cancellationToken);
    }
}

}
