namespace Project_ERM.Erm.BusinessLayer;
public readonly record struct RiskProfileInfo( // здесь не нужно писать конструктор для обращения в PresentationLayerConsole потому что компилятор автоматически создает конструктор
    string? Name,
    string? Description,
    string? BusinessProcess,
    int OccurrenceProbability,
    int PotentialBusinessImpact
);