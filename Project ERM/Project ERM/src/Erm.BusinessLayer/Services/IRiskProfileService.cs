using Erm.BusinessLayer;

namespace Project_ERM.Erm.BusinessLayer.Services;

public interface IRiskProfileService
{
    void Create(RiskProfileInfo profileInfo);

    IEnumerable<RiskProfileInfo> Query(string query);

}
