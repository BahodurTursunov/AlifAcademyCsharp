namespace HW17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultAdd = Calculator.Add(5, 6);
            Console.WriteLine(resultAdd);

            var resultMultiplly = Calculator.Multiply(5, 6);
            Console.WriteLine(resultMultiplly);
        }
    }
}
