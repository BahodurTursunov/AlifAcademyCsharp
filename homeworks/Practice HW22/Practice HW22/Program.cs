namespace Practice_HW22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (personName, personAge) = GetPersonInfo();

            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }

        static (string name, int age) GetPersonInfo() => ("John", 30);
    }
}
