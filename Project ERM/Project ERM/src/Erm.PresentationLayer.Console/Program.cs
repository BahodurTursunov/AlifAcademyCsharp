using Erm.BusinessLayer;

class Program
{
    static void Main(string[] args)
    {
        const string _exit = "exit";
        string cmd = Console.ReadLine();

        while (cmd != _exit)
        {
            cmd = Console.ReadLine();
        }
    }
}