/*
4.  У вас есть массив чисел. Напишите программу,которая выводит сумму всех нечетных чисел в массиве.
*/

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int resultSum = SumOfOddNumbers(arr);
        Console.WriteLine(resultSum);
    }

    static int SumOfOddNumbers(int[] numbers)
    {
        int result = 0;

        foreach (var num in numbers) // здесь используя цикл foreach проходимся по каждому элементу массива 
        {
            if (num % 2 != 0) // здесь проверяется условие на нечетность 
            {
                result += num; // а здесь нечетные числа суммируются
            }
        }
        return result; // здесь все возвращается
    }
}