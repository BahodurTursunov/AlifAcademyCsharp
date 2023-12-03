class Program
{
    static void Main(string[] args)
    {
        // explicit casting. потерь при неявном преобразовании не будет.
        /*
        int number = 12345;
        long longNumb = number;
        Console.WriteLine(longNumb);
        */
        //Implicit catring. Явное преобразование
        /*long longNumber2 = long.MaxValue;
        int number2 = (int) longNumber2;
        Console.WriteLine(number2);
        */
        /*double doubleNumber = 12345.7;
        int integerNumber = (int)doubleNumber;
        Console.WriteLine(integerNumber);
        */
        /*

        long longNumber3 = long.MaxValue;
        object obj = longNumber3;
        Console.WriteLine("longnum3" + longNumber3);
        longNumber3 = (long)obj;
        Console.WriteLine("longnum3" + longNumber3);
        */


        string s = "Hello, World!";
        object o = s;
        s = (string) o;
        Console.WriteLine(Object.ReferenceEquals(s,o));
    }
}