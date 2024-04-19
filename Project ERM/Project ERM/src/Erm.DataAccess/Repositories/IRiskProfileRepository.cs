namespace Project_ERM.Erm.DataAccess.Repositories;

internal interface IRiskProfileRepository
{
    public Task CreateAsync(RiskProfile entity, CancellationToken token = default); // Task в асинхронности ипсользуется вместо void тогда, когда нам не нужно ничего возвращать
    public Task<RiskProfile> GetAsync(string name, CancellationToken token = default);
    public Task<IEnumerable<RiskProfile>> QueryAsync(string query, CancellationToken token = default); // вместо IEnumerable лучше всего использовать IAsyncEnumerable - эту тему изучить, чтобы понять когда и где использовать этот интерфейс и какие возможности он дает
    public Task UpdateAsync(string name, RiskProfile riskProfile, CancellationToken token = default);
    public Task DeleteAsync(string name, CancellationToken token = default);
}