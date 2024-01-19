namespace lesson_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = GetNumber();

            var (_, number2, _) = GetTupleNumber();

            (_, int _, int number3) = GetTupleNumber();

        }


        static int GetNumber() => 100;

        static (int, int, int) GetTupleNumber() => (100, 200, 300);

    }
}
