
namespace lesson13_OOP__class_continue_
{

    public class Math
    {
        public static float PI = 3.14f;

        public static int add(int a)
        {
            return a + a;
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, short c) // Здесь мы можем написать тертий входной параметр тот который нам нужен
        {
            return a + b + c;
        }

        public static float add(float a, float b, float c, float d)
        {
            return a + b + c + d;
        }

        public static float add(float a, float b, float c, float d, float e)
        {
            return a + b + c + d + e;
        }

        public float Division(int a, float b)
        {
            float res = PI / b;
            return res;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Acount acount = new()
            //{
            //    Amount = 100
            //};
            //acount++;
            //Acount acount2 = acount++;
            //Console.WriteLine(acount.Amount);
            //Console.WriteLine(acount2.Amount);
            //Acount acount1 = new();
            //Acount acount2 = acount + acount1;

            //int res = Math.add(2);
            //Console.WriteLine(acount);

            Acount acc = new()
            {
                Amount = { 1, 2, 3, 4, 5 }
            };

            
        }
    }
}
