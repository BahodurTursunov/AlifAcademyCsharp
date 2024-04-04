using Project_ERM.Erm.DataAccess;

namespace Erm.DataAccess;

public sealed class RiskProfileRepository : IRiskProfileRepository
{
    private static readonly List<RiskProfile> _db;

    static RiskProfileRepository() => _db = new(capacity: 100);

    public void Create(RiskProfile entity) => _db.Add(entity);

    public IEnumerable<RiskProfile> Query(string query)
    {
        return _db.Where(x => x.RiskName.Contains(query) || x.Description.Contains(query));

        /*// метод where делает то что написано ниже

        //foreach (RiskProfile riskProfile in _db)
        //{
        //    if(riskProfile.RiskName.Contains(query) || riskProfile.Description.Contains(query))
        //    {
        //        yield return riskProfile;
        //    }
        //}*/
    }

    public void Delete(string name)
    {

    }
    public RiskProfile Get(string name) => _db.Single(x => x.RiskName.Equals(name));

    public void Update(string name, RiskProfile riskProfile)
    {
        throw new NotImplementedException();
    }
}