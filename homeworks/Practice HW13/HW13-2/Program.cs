namespace HW13_2
{
    using System;

    public class Matrix2x2
    {
        public int[,] Elements { get; }

        public Matrix2x2(int a, int b, int c, int d)
        {
            Elements = new int[2, 2] { { a, b }, { c, d } };
        }

        public static Matrix2x2 operator +(Matrix2x2 m1, Matrix2x2 m2)
        {
            return new Matrix2x2(
                m1.Elements[0, 0] + m2.Elements[0, 0],
                m1.Elements[0, 1] + m2.Elements[0, 1],
                m1.Elements[1, 0] + m2.Elements[1, 0],
                m1.Elements[1, 1] + m2.Elements[1, 1]
            );
        }

        public static Matrix2x2 operator *(Matrix2x2 m1, Matrix2x2 m2)
        {
            return new Matrix2x2(
                m1.Elements[0, 0] * m2.Elements[0, 0] + m1.Elements[0, 1] * m2.Elements[1, 0],
                m1.Elements[0, 0] * m2.Elements[0, 1] + m1.Elements[0, 1] * m2.Elements[1, 1],
                m1.Elements[1, 0] * m2.Elements[0, 0] + m1.Elements[1, 1] * m2.Elements[1, 0],
                m1.Elements[1, 0] * m2.Elements[0, 1] + m1.Elements[1, 1] * m2.Elements[1, 1]
            );
        }

        public override string ToString()
        {
            return $"[{Elements[0, 0]}, {Elements[0, 1]}\n {Elements[1, 0]}, {Elements[1, 1]}]";
        }
    }

    class Program
    {
        static void Main()
        {
            Matrix2x2 matrix1 = new Matrix2x2(1, 2, 3, 4);
            Matrix2x2 matrix2 = new Matrix2x2(1, 2, 3, 4);

            Matrix2x2 sum = matrix1 + matrix2;
            Matrix2x2 product = matrix1 * matrix2;

            Console.WriteLine($"Sum:\n{sum}");
            Console.WriteLine($"Product:\n{product}");
        }
    }

}
