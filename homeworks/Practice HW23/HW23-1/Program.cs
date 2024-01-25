
namespace HW23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Input first number >>>");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("<<< Input second number >>>");
            int secondNum = int.Parse(Console.ReadLine());
            try
            {
                int result = firstNum / secondNum;
                Console.WriteLine($"\n <<< Result: {result} >>>");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }
        }
    }
}
