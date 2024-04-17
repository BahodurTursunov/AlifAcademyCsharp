namespace Project_ERM.Erm.DataAccess.Repositories;

internal interface IRiskProfileRepository
{
    public void Create(RiskProfile entity);
    public RiskProfile Get(string name);
    public IEnumerable<RiskProfile> Query(string query);
    public void Update(string name, RiskProfile riskProfile);
    public void Delete(string name);
}