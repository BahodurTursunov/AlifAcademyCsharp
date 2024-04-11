using Erm.BusinessLayer;
using Project_ERM.Erm.DataAccess;
namespace Project_ERM.Erm.BusinessLayer;
internal static class RiskProfileInfoExtention
{
    internal static RiskProfile ToRiskProfile(this RiskProfileInfo profileInfo) => new()
    {
        RiskName = profileInfo.Name,
        Description = profileInfo.Description,
        BusinessProcess = new() { Name = profileInfo.BusinessProcess, Domain = profileInfo.BusinessProcess },
        PotentialBusinessImpact = profileInfo.PotentialBusinessImpact,
        OccurrenceProbability = profileInfo.OccurrenceProbability
    };
}
