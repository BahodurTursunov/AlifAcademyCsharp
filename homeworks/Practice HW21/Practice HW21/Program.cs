namespace Practice_HW21
{

    class Program
    {
        static void Main(string[] args)
        {

            object userInput1 = "Hello";
            object userInput2 = 2; 
            PatternMatching(userInput1);
            PatternMatching(userInput2);
        }

        static void PatternMatching(object obj)
        {
            if (obj is string str)
                Console.WriteLine($"{str.Length}");
            else
                Console.WriteLine("Это не строка");
        }
    }
}
