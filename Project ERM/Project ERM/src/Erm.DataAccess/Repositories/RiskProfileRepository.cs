using Project_ERM.Erm.DataAccess;

namespace Erm.DataAccess;

public sealed class RiskProfileRepository : IRiskProfileRepository
{
    private static readonly List<RiskProfile> _db;

    static RiskProfileRepository() => _db = new(capacity: 100);

    public void Create(RiskProfile entity) => _db.Add(entity);

    public void Delete(string name)
    {
        throw new NotImplementedException();
    }

    public RiskProfile Get(string name) => _db.Single(x => x.RiskName.Equals(name));

    public void Update(string name, RiskProfile riskProfile)
    {
        throw new NotImplementedException();
    }
}