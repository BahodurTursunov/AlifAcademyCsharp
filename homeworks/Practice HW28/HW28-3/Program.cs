namespace HW28_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> _dictionary = new()
            {
                { "Bob", "+992928650046" },
                { "Tom", "+992928465787" },
                { "Alex", "+992294958567" },
                { "Sam", "+992123455667" }
            };

            Console.WriteLine("Исходный словарь:");
            DisplayValues(_dictionary);

            Console.WriteLine();

            Console.WriteLine("Словарь после удаления ключа:");
            _dictionary.Remove("Alex");
            DisplayValues(_dictionary);

            Console.WriteLine();
            // метод для поиска значения по ключу

            string _searchKey = "Tom";

            if (_dictionary.ContainsKey(_searchKey))
            {
                string value = _dictionary[_searchKey];
                Console.WriteLine($"Найден элемент по ключу: {value}");
            }
            else Console.WriteLine($"Элемент с ключем {_searchKey} не найден");
        }

        static void DisplayValues(Dictionary<string, string> _dictionary)
        {
            foreach (var values in _dictionary)
            {
                Console.WriteLine($"- {values}");
            }
        }
    }
}
