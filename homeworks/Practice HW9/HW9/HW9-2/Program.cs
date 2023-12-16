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
        MathOperation substraction = new MathOperation(Subtraction);
        MathOperation multiplication = new MathOperation(Multiplication);
        MathOperation division = new MathOperation(Division);

        int resSubstraction = PerformOperation(10, 2, Subtraction);
        Console.WriteLine($"Вычитание: {resSubstraction}");

        int resMultiplication = PerformOperation(10, 2, Multiplication);
        Console.WriteLine($"Умножение: {resMultiplication}");

        int resDivision = PerformOperation(10, 0, Division);
        Console.WriteLine($"Деление: {resDivision}");

    }

    static int PerformOperation(int a, int b, MathOperation operation)
    {
        return operation(a, b);
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
