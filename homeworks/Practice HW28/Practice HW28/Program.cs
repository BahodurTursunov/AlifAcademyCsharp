namespace Practice_HW28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArray = new MyArray(5);

            myArray[0] = 1;

            Console.WriteLine(myArray[0]);

            myArray[1, 2] = 20;
            Console.WriteLine(myArray[1, 2]);
        }
    }

    public class MyArray(int size)
    {
        private readonly int[] _array = new int[size];
        private readonly int[,] _twoDimensionalArray = new int[size, size];

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public int this[int row, int column]
        {
            get => _twoDimensionalArray[row, column];
            set => _twoDimensionalArray[row,column] = value;
        }

    }
}
