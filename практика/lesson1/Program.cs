using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // Примеры для разных типов данных
        int intValue = 42;
        double doubleValue = 3.14;
        string stringValue = "Hello, World!";

        Console.WriteLine($"Размер int: {GetSize(intValue)} байт");
        Console.WriteLine($"Размер double: {GetSize(doubleValue)} байт");
        Console.WriteLine($"Размер string: {GetSize(stringValue)} байт");
    }

    static int GetSize<T>(T obj)
    {
        return Marshal.SizeOf(obj);
    }
}
