namespace HW17_2
{
    public class Calculator : IMath
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return (a * b);
        }
    }
}
