using Project_ERM.src.Erm.DataAccess;

namespace Project_ERM.Erm.DataAccess.Repositories;
public sealed class RiskProfileRepository : IRiskProfileRepository
{
    private readonly ErmDbContext _db = new();
    public async Task CreateAsync(RiskProfile entity, CancellationToken token = default)
    {
        await _db.RiskProfiles.AddAsync(entity, token);
        await _db.SaveChangesAsync(token);
    }

    public async Task DeleteAsync(string name, CancellationToken token = default)
    {
        await _db.RiskProfiles.Where(x => x.RiskName.Equals(name)).ExecuteDeleteAsync(token);
        await _db.SaveChangesAsync(token);
    }

    public async Task<RiskProfile> GetAsync(string name, CancellationToken token = default) // мы можем убрать async await потому что SingleAsync принимает такое
        => await _db.RiskProfiles
        .AsNoTracking()
        .Include(i => i.BusinessProcess)
        .SingleAsync(x => x.RiskName.Equals(name), token);

    public async Task<IEnumerable<RiskProfile>> QueryAsync(string query, CancellationToken token = default)
        => await _db.RiskProfiles
        .AsNoTracking()
        .Include(i => i.BusinessProcess)
        .Where(x => x.RiskName.Contains(query) || x.Description.Contains(query)).ToArrayAsync(token);

    public async Task UpdateAsync(string name, RiskProfile riskProfile, CancellationToken token = default)
    {
        RiskProfile profileToUpdate = await _db.RiskProfiles.SingleAsync(x => x.RiskName.Equals(name), token);

        profileToUpdate.RiskName = riskProfile.RiskName;
        profileToUpdate.Description = riskProfile.Description;
        profileToUpdate.PotentialBusinessImpact = riskProfile.PotentialBusinessImpact;
        //profileToUpdate.PotentialSolution = riskProfile.PotentialSolution;
        profileToUpdate.OccurrenceProbability = riskProfile.OccurrenceProbability;

        await _db.SaveChangesAsync(token);
    }

    /*// метод where делает то что написано ниже
//foreach (RiskProfile riskProfile in _db)
//{
//    if(riskProfile.RiskName.Contains(query) || riskProfile.Description.Contains(query))
//    {
//        yield return riskProfile;
//    }
//}*/



}
// еще есть метод asnotracking перед where