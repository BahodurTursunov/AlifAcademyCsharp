/* 
 * 1. Объявите две переменные age и isStudent. Напишите условие, которое будет истинным, если возраст (age) больше 18 
 * и человек не является студентом (isStudent равно false).
 */
class Program
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        bool isStudent = false;

        if(age >= 18 || isStudent) Console.WriteLine("true");
        else Console.WriteLine("false");
    }
}
