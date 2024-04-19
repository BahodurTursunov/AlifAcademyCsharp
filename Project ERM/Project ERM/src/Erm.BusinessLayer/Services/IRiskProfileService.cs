
using Erm.BusinessLayer;

namespace Project_ERM.Erm.BusinessLayer.Services;

public interface IRiskProfileService
{
    public Task CreateAsync(RiskProfileInfo riskProfileInfo, CancellationToken token = default);
    Task<IEnumerable<RiskProfileInfo>> QueryAsync(string query, CancellationToken token = default); 
    Task<RiskProfileInfo> GetAsync(string name, CancellationToken token = default);

}