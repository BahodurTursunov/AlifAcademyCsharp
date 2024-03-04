using Erm.BusinessLayer;

class Program
{
    static void Main(string[] args)
    {
        string riskName = Console.ReadLine();
        string description = Console.ReadLine();

        RiskProfileInfo riskProfileInfo = new()
        {
            Name = riskName,
            Description = description
        };
    }
}