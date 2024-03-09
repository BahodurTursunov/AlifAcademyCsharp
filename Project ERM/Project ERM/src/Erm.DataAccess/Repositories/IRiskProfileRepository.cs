using Project_ERM.Erm.DataAccess;

namespace Erm.DataAccess;

public interface IRiskProfileRepository
{
    public void Create(RiskProfile entity);
    public RiskProfile Get(string name);
    public void Update(string name, RiskProfile riskProfile);
    public void Delete(string name);
}
