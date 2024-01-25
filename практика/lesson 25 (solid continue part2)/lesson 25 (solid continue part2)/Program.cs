namespace lesson_25__solid_continue_part2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NetworkClient networkClient = new("example.com");
            networkClient.Send(new{UserName = "Abdu", Password = "123456"});
        }
    }

}
