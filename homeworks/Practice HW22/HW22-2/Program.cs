namespace HW22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new("Tom and Jerry", "Karl Davidson");

            (string title, string author) = myBook;

            Console.WriteLine($"Title: {title}\nAuthor: {author}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Deconstruct(out string bookTitle, out string bookAuthor)
        {
            bookTitle = Title;
            bookAuthor = Author;
        }
    }
}
