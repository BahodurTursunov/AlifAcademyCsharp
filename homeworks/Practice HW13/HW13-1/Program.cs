namespace HW13_1
{

    class Program
    {
        static void Main()
        {
            ComplexNumber complex1 = new ComplexNumber(2, 3);
            ComplexNumber complex2 = new ComplexNumber(1, 4);

            ComplexNumber sum = complex1 + complex2;
            ComplexNumber difference = complex1 - complex2;
            ComplexNumber product = complex1 * complex2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
        }

        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }

            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
            }

            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(
                    a.Real * b.Real - a.Imaginary * b.Imaginary,
                    a.Real * b.Imaginary + a.Imaginary * b.Real
                );
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }
        }
    }

}
