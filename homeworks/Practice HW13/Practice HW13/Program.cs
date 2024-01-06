using System;
using System.Linq;

public static class ArrayExtensions
{
    public static double CalculateAverage(this int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array is null or empty");

        return array.Sum() / (double)array.Length;
    }
}

class Program
{
    static void Main()
    {
        int[] integerArray = { 1, 2, 3, 4, 5 };
        double averageInteger = integerArray.CalculateAverage();

        Console.WriteLine($"Average of integerArray: {averageInteger}");

        int[] intArray = { 2,2,2,2,2 };
        double averageDouble = intArray.CalculateAverage();

        Console.WriteLine($"Average of doubleArray: {averageDouble}");
    }
}
