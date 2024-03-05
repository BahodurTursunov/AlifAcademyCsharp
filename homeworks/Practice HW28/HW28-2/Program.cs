namespace HW28_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tom",
                "Bob",
                "Alex"
            };

            Console.WriteLine("Исходный список имен:");
            DisplayName(names);

            names.Remove("Bob");

            Console.WriteLine("Список имен после удаления:");
            DisplayName(names);
        }

        static void DisplayName(List<string> namesList)
        {
            foreach (var name in namesList)
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
