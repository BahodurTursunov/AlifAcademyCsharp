using Erm.DataAccess;

namespace Project_ERM.Erm.DataAccess.Repositories;

public sealed class RiskProfileRepository : IRiskProfileRepository
{
    private readonly ErmDbContext.ErmDbContext _db = new();
    public void Create(RiskProfile entity)
    {
        _db.RiskProfiles.Add(entity);
        _db.SaveChanges();
    }
    public IEnumerable<RiskProfile> Query(string query) => _db.RiskProfiles.Where(x => x.RiskName.Contains(query) || x.Description.Contains(query)).ToArray();
        /*// метод where делает то что написано ниже
        //foreach (RiskProfile riskProfile in _db)
        //{
        //    if(riskProfile.RiskName.Contains(query) || riskProfile.Description.Contains(query))
        //    {
        //        yield return riskProfile;
        //    }
        //}*/

    public void Delete(string name)
    {
        _db.RiskProfiles.Where(x => x.RiskName.Equals(name)).ExecuteDelete();
        _db.SaveChanges();
    }
    public RiskProfile Get(string name) => _db.RiskProfiles.Single(x => x.RiskName.Equals(name));
    public void Update(string name, RiskProfile riskProfile)
    {
        RiskProfile profileToUpdate = _db.RiskProfiles.Single(x => x.RiskName.Equals(name));
        
        profileToUpdate.RiskName = riskProfile.RiskName;
        profileToUpdate.Description = riskProfile.Description;
        profileToUpdate.PotentialBusinessImpact = riskProfile.PotentialBusinessImpact;
        profileToUpdate.PotentialSolution = riskProfile.PotentialSolution;
        profileToUpdate.OccurrenceProbability = riskProfile.OccurrenceProbability;
        
        _db.SaveChanges();
    }
}
// еще есть метод asnotracking перед where