/*
 * Даны две логические переменные, a и b. Напишите выражение,
 * которое равно true только в том случае, если ровно одна из переменных a или b равна true.
 */

class Program
{
    static void Main(string[] args)
    {
        bool a = true;
        bool b = false;

        bool result = a ^ b; // здесь оператор ^ означает исключающее или.
        Console.WriteLine(result);
    }
}