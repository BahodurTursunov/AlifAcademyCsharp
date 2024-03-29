namespace Erm.BusinessLayer;

public interface IRiskProfileService
{
    void Create(RiskProfileInfo profileInfo);

    IEnumerable<RiskProfileInfo> Query(string query);

}
