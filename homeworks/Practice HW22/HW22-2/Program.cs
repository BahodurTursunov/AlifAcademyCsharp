namespace HW22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new()
            {
                Title = "Iron man",
                Author = "Junior"
            };

            var (bookTitle, bookAuthor) = myBook;

            Console.WriteLine($"Title: {bookTitle} Author: {bookAuthor}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Deconstruc(out string title, out string author)
        {
            title = Title;
            author = Author;
        }
    }
}
