using Erm.BusinessLayer;

using Project_ERM.Erm.BusinessLayer.Services;
using Project_ERM.Erm.DataAccess;

class Program
{
    static void Main(string[] args)
    {
        IRiskProfileService riskProfileService = new RiskProfileService();

        string? cmd = Console.ReadLine();

        while (!cmd.Equals(CommandHelper.ExitCommand))
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Gray; // Reset console foreground color to default.

                Console.Write(CommandHelper.InputSymbol);

                switch (cmd)
                {
                    case CommandHelper.CreateRiskProfileCommand:
                        Console.WriteLine("Введите имя риска: ");
                        string rpName = Console.ReadLine();

                        Console.WriteLine("Введите описание риска: ");
                        string rpDescription = Console.ReadLine();

                        Console.WriteLine("Введите название бизнесс процесса и область применения: ");
                        string rpBusinessProcess = Console.ReadLine();

                        Console.WriteLine("Введите возникновение риска по шкале (1 - 10): ");
                        bool rpOccurrenceProbability = int.TryParse(Console.ReadLine(), out int _rpOccurrenceProbability);

                        Console.WriteLine("Введите потенциальное влияние на бизнес по шкале (1 - 10): "); 

                        bool rpPotentialBusinessImpact = int.TryParse(Console.ReadLine(), out int _rpPotentialBusinessImpact);

                        RiskProfileInfo riskProfileInfo = new(rpName, rpDescription, rpBusinessProcess, _rpOccurrenceProbability, _rpPotentialBusinessImpact);

                        riskProfileService.Create(riskProfileInfo);
                        break;

                    case CommandHelper.QueryRiskProfileCommand:
                        string query = Console.ReadLine();
                        IEnumerable<RiskProfileInfo> profileInfos = riskProfileService.Query(query);
                        foreach (var item in profileInfos)
                        {
                            Console.WriteLine(item);
                        } 
                        
                        break;
                    case CommandHelper.HelpCommand:
                        Console.WriteLine(CommandHelper.InputSymbol + CommandHelper.CreateRiskProfileCommand + " -> " + CommandHelper.CreateRiskProfileDescription); break;

                    case CommandHelper.ExitCommand:
                        Console.WriteLine("Successfully exit"); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(CommandHelper.UnknownCommandMessage);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(CommandHelper.InputSymbol + ex.Message);
            }
        }
    }
}

file static class CommandHelper
{
    public const string InputSymbol = "> ";

    public const string ExitCommand = "exit";

    public const string HelpCommand = "help";

    public const string CreateRiskProfileCommand = "create_profile";

    public const string QueryRiskProfileCommand = "search_profile";

    public const string CreateRiskProfileDescription = "Creates Risk Profile";

    public const string UnknownCommandMessage = "Unknown command, use help to see list of available commands.";

}