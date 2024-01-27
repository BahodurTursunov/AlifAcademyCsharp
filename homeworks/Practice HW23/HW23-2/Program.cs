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
