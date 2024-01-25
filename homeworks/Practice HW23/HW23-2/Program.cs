/*
 * 2.  Используйте пользовательское исключение, создав свой собственный класс исключений 
 * (например, MyCustomException), производный от Exception. В своей программе намеренно вызовите это
 * пользовательское исключение с помощью ключевого слова throw.

 */

namespace HW23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyCustomException("This is my exception");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Catch exception: {ex.Message}");
            }
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {
            
        }
    }
}
