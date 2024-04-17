using Erm.BusinessLayer;
using Project_ERM.Erm.BusinessLayer.Services;
class Program
{
    static void Main(string[] args)
    {
        IRiskProfileService riskProfileService = new RiskProfileService();

        string? cmd = string.Empty;

        while (!cmd.Equals(CommandHelper.ExitCommand))
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Gray; // Reset console foreground color to default.

                cmd = Console.ReadLine();

                Console.Write(CommandHelper.InputSymbol);

                switch (cmd)
                {
                    case CommandHelper.CreateRiskProfileCommand:
                        Console.WriteLine("Введите имя риска: ");
                        string riskName = Console.ReadLine();

                        Console.WriteLine("Введите описание риска: ");
                        string riskDescription = Console.ReadLine();

                        Console.WriteLine("Введите название бизнесс процесса и область применения: ");
                        string riskBusinessProcess = Console.ReadLine();

                        Console.WriteLine("Введите возникновение риска по шкале (1 - 10): ");
                        int riskOccurrenceProbability;
                        while (!int.TryParse(Console.ReadLine(), out riskOccurrenceProbability))
                        {
                            Console.WriteLine("Неправильно введенные данные, пожалуйста ведите число от 0 до 10");
                        }

                        Console.WriteLine("Введите потенциальное влияние на бизнес по шкале (1 - 10): ");
                        int riskPotentialBusinessImpact;
                        while (!int.TryParse(Console.ReadLine(), out riskPotentialBusinessImpact))
                        {
                            Console.WriteLine("Неправильно введенные данные, пожалуйста ведите число от 0 до 10");
                        }

                        RiskProfileInfo riskProfileInfo = new()
                        {
                            Name = riskName,
                            Description = riskDescription,
                            BusinessProcess = riskBusinessProcess,
                            OccurrenceProbability = riskOccurrenceProbability,
                            PotentialBusinessImpact = riskPotentialBusinessImpact
                        };

                        riskProfileService.Create(riskProfileInfo);
                        break;

                    case CommandHelper.QueryRiskProfileCommand:
                        string? query = Console.ReadLine();
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

    public const string CreateRiskProfileCommand = "cr";

    public const string QueryRiskProfileCommand = "search_profile";

    public const string CreateRiskProfileDescription = "Creates Risk Profile";

    public const string UnknownCommandMessage = "Unknown command, use help to see list of available commands.";
}