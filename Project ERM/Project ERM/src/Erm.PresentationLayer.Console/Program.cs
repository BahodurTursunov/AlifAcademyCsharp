using System.Threading.Channels;

using Erm.BusinessLayer;
using Erm.DataAccess;

class Program
{
    static void Main(string[] args)
    {
        IRiskProfileService riskProfileService = new RiskProfileService();

        string? cmd = Console.ReadLine();

        while (!cmd.Equals(CommandHelper.ExitCommand))
        {
            Console.ForegroundColor = ConsoleColor.Gray; // Reset console foreground color to default.

            Console.Write(CommandHelper.InputSumbol);
            cmd = Console.ReadLine();

            switch (cmd)
            {
                case CommandHelper.CreateRiskProfileCommand:
                    string rpName = Console.ReadLine(); // required

                    string rpDescription = Console.ReadLine();

                    string rpBusinessProcess = Console.ReadLine();

                    int rpOccurrenceProbability = int.Parse(Console.ReadLine());

                    int rpPotentialBusinessImpact = int.Parse(Console.ReadLine()); //

                    RiskProfile riskProfileInfo = new(rpName, rpDescription, rpBusinessProcess, rpOccurrenceProbability, rpPotentialBusinessImpact); // придумать инструмент валидации

                    riskProfileService.Create(riskProfileInfo);

                    Console.WriteLine(); break;

                case CommandHelper.HelpCommand:
                    Console.WriteLine(CommandHelper.InputSumbol + CommandHelper.CreateRiskProfileCommand + " -> " + CommandHelper.CreateRiskProfileDescription); break;

                case CommandHelper.ExitCommand:
                    Console.WriteLine("Successfully exit"); break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(CommandHelper.UnknownCommandMessage);
                    break;
            }
        }
    }
}

file static class CommandHelper
{
    public const string InputSumbol = "> ";

    public const string ExitCommand = "exit";

    public const string HelpCommand = "help";

    public const string CreateRiskProfileCommand = "create_profile";

    public const string CreateRiskProfileDescription = "Creates Risk Profile";

    public const string UnknownCommandMessage = "Unknown command, use help to see list of available commands.";

}