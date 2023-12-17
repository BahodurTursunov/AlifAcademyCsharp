/*
 2. Реализуйте три метода, каждый из которых выполняет разные операции (например,
сложение, вычитание, умножение) с использованием делегата. Проверьте эти методы
вызвав их через делегата и отобразив результаты на экране.

 */

public delegate int MathOperation(int a, int b);

class Program
{

    static void Main(string[] args)
    {
        MathOperation substraction = new(Subtraction);
        MathOperation multiplication = new(Multiplication);
        MathOperation division = new(Division);

        int resSubstraction = Subtraction(10, 2);
        Console.WriteLine($"Вычитание: {resSubstraction}");

        int resMultiplication = Multiplication(10, 2);
        Console.WriteLine($"Умножение: {resMultiplication}");

        int resDivision = Division(10, 0);
        Console.WriteLine($"Деление: {resDivision}");

    }

    static int Subtraction(int a, int b) => a - b;

    static int Multiplication(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return 0;
        }
        return a * b;
    }

    static int Division(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            Console.WriteLine("На ноль делить нельзя");
        }
        return a / b;
    }
}
