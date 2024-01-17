namespace lesson20
{
    public class BaseEntity
    {
        public long id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public sealed class Customer : BaseEntity
    {
        public string? Name { get; set; }
    }

    public sealed class Order : BaseEntity
    {
        public string? Description { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
