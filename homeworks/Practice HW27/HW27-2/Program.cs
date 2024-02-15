namespace HW27_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string?> dic = new Dictionary<int, string?>()
            {
                {1, "Bakha" },
                {2, "Tom" },
                {3, "Bob" }
            };

            Console.WriteLine("Содержимое словаря:");

            foreach (var item in dic)
            {
                Console.WriteLine($"key: {item.Key} value: {item.Value}\n");
            }

            int searchKey = int.Parse(Console.ReadLine());

            if (dic.ContainsKey(searchKey))
            {
                string? name = dic[searchKey];
                Console.WriteLine($"Ключ {searchKey}, Имя: {name}");
            }
            else Console.WriteLine($"Элемент с ключем {searchKey} не найден");
        }
    }
}
