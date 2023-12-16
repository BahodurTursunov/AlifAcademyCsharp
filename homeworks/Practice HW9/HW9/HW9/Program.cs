/*
 * 1. Создайте консольное приложение C#, демонстрирующее использование метода. 
метод должен принимать два целых числа в качестве входных параметров и возвращать их
сумму. Вызовите этот метод из метода Main и отобразите результат на
экран.
*/

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int res = Sum(firstNumber, secondNumber);
        Console.WriteLine(res);

    }

    static int Sum(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}