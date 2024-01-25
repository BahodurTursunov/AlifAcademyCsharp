namespace HW17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var resultAdd = Calculator.Add(5, 6);
            //Console.WriteLine(resultAdd);

            //var resultMultiplly = Calculator.Multiply(5, 6);
            //Console.WriteLine(resultMultiplly);

            //Exception
            J();

            int[] number = { 1, 2, 3, 4, 5, 6 };

            try
            {
                Console.WriteLine(number[8]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Не получилось");
            }

            void J()
            {
                J();
            }
        }
    }
}
