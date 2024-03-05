namespace HW28_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> books = new SortedList<string, string>();

            books.Add("123456789", "Война и мир");
            books.Add("1234567", "Преступление и наказание");
            books.Add("12345678", "Мастер и Маргарита");

            Console.WriteLine("Список книг:");
            DisplayBooks(books);

            books.Remove("1234567");

            Console.WriteLine("\nСписок книг после удаления:");
            DisplayBooks(books);
        }

        static void DisplayBooks(SortedList<string, string> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.Key}, Название: {book.Value}");
            }
        }
    }
}


