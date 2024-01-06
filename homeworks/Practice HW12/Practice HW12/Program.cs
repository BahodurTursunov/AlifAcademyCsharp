namespace Practice_HW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            person.DisplayFullName();
        }
    }
}
