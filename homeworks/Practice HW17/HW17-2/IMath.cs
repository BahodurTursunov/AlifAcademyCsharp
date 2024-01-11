using System.Runtime.CompilerServices;

namespace HW17_2
{
    interface IMath
    {
        static int Add(int a, int b) { return a + b; }
        static int Multiply(int a, int b) { return a * b; }


        //public static int Add(int firstNum, int secondNum)
        //{
        //    return firstNum + secondNum;
        //}
        //public static int Multiply(int firstNum, int secondNum)
        //{
        //    return firstNum * secondNum;
        //}

        //static void Add(int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"{firstNum} + {secondNum} = ", firstNum + secondNum);
        //}

        //static void Multiply(int firstNum, int secondNum)
        //{
        //    Console.WriteLine($"{firstNum} * {secondNum} = ", firstNum * secondNum);
        //}
    }
}
