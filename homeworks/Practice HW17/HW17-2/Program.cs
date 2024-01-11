namespace HW17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new();
            Console.WriteLine(calc.Add(2, 5));
            Console.WriteLine(calc.Multiply(10, 2));

        }
    }
}
