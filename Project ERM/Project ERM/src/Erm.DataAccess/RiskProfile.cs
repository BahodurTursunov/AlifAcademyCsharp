using Erm.BusinessLayer;

using Project_ERM.src.Erm.DataAccess;

namespace Erm.DataAccess;

public sealed class RiskProfile
{
    private int _occurrenceProbability;
    private int _potentialBusinessImpact;

    public required string RiskName { get; set; } // название риска
    public string? Description { get; set; } // описание/характеристика риска
    public required BusinessProcess BusinessProcess { get; set; } // связанные бизнес-процессы, или подразделения
    public required int OccurrenceProbability // вероятность возникновения риска
    {
        get => _occurrenceProbability;
        set => _occurrenceProbability = (value < 1 || value > 10)
            ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
    }
    public required int PotentialBusinessImpact // потенциальное влияние на бизнес
    {
        get => _potentialBusinessImpact;
        set => _potentialBusinessImpact = (value < 1 || value > 10)
            ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
    }
    public string? PotentialSolution { get; set; } // потенциальное решение риска

    // TODO: create construct for riskprofileinfo
}