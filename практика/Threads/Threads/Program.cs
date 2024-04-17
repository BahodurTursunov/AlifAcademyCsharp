namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CalcellationToken это такая структура хранящая в себе информацию, был ли 
            CancellationTokenSource tokenSource = new();
            CancellationToken token = tokenSource.Token;
            token.Register(() =>
            {
                Console.WriteLine("Cancellation Request");
            });

            Thread thread2 = new(() =>
            {
                foreach (int number in Enumerable.Range(0, 100))
                {
                    try
                    {
                        Console.WriteLine(number + " " + Thread.CurrentThread.Name);
                        Thread.Sleep(300);
                        token.ThrowIfCancellationRequested();
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("OPERATION CANCELED");
                        return;
                    }
                    catch(ThreadAbortException)
                    {
                        continue;
                    }
                }
            });
            thread2.Priority = ThreadPriority.Lowest;
            thread2.Name = "Custom Thread2";
            thread2.Start();


            //tokenSource.CancelAfter(1000);


            try
            {
                Thread thread = new(() =>
                {
                    throw new Exception("EXCEPTION FROM THREAD!");
                });
                thread.Priority = ThreadPriority.Highest;
                thread.Name = "Custom Thread";
                thread.Start();
            }
            catch
            {
                Console.WriteLine("EXCEPTION HANDLED");
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
