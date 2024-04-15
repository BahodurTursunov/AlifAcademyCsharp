using Project_ERM.Erm.DataAccess.DataBaseContext;
namespace Project_ERM.Erm.DataAccess.Repositories;

public sealed class RiskProfileRepository(ErmDbContext dbContext) : IRiskProfileRepository
{
    public void Create(RiskProfile entity)
    {
        dbContext.Add(entity);
        dbContext.SaveChanges();
    }
    public IEnumerable<RiskProfile> Query(string query) => dbContext.RiskProfiles.Where(x => x.RiskName.Contains(query) || x.Description.Contains(query)).ToArray();
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
        dbContext.RiskProfiles.Where(x => x.RiskName.Equals(name)).ExecuteDelete();
        dbContext.SaveChanges();
    }
    public RiskProfile Get(string name) => dbContext.RiskProfiles.Single(x => x.RiskName.Equals(name));
    public void Update(string name, RiskProfile riskProfile)
    {
        RiskProfile profileToUpdate = dbContext.RiskProfiles.Single(x => x.RiskName.Equals(name));
        
        profileToUpdate.RiskName = riskProfile.RiskName;
        profileToUpdate.Description = riskProfile.Description;
        profileToUpdate.PotentialBusinessImpact = riskProfile.PotentialBusinessImpact;
        profileToUpdate.PotentialSolution = riskProfile.PotentialSolution;
        profileToUpdate.OccurrenceProbability = riskProfile.OccurrenceProbability;
        
        dbContext.SaveChanges();
    }
}
// еще есть метод asnotracking перед where