
using Erm.BusinessLayer;

namespace Project_ERM.Erm.BusinessLayer.Services;

public interface IRiskProfileService
{
    public void Create(RiskProfileInfo riskProfileInfo);
    IEnumerable<RiskProfileInfo> Query(string query);

}