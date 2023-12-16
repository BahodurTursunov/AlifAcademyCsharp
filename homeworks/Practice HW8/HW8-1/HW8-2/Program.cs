/*2. Напишите программу, которая выводит числа от 1 до 100. Если число делится на 3, выведите "Fizz". Если число делится на 5, выведите "Buzz".
 * Если число делится и на 3, и на 5, выведите "FizzBuzz". В противном случае выведите само число.*/

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
}