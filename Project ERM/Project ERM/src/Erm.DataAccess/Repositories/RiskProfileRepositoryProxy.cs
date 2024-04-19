using System.Text.Json;

using Project_ERM.Erm.DataAccess;
using Project_ERM.Erm.DataAccess.Repositories;

using StackExchange.Redis;

namespace Project_ERM.Erm.DataAccess;

public sealed class RiskProfileRepositoryProxy : IRiskProfileRepository
{
    private readonly RiskProfileRepository _originalRepository;

    private readonly IDatabase _redisDb;

    private const string RedisHost = "127.0.0.1:6379";

    public RiskProfileRepositoryProxy(RiskProfileRepository originalRepository)
    {
        _originalRepository = originalRepository;
        ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect(RedisHost);
        _redisDb = connectionMultiplexer.GetDatabase();
    }

    public  Task CreateAsync(RiskProfile entity, CancellationToken token = default) =>  _originalRepository.CreateAsync(entity, token); // TODO: SET realisation in here
    
    // и если наши типы имеют одинаковые названия (совпадают по назнавиям), то не обязательно писать async await, потому что создается какая то проверка и генерируется много кода
    public  Task DeleteAsync(string name, CancellationToken token = default) =>  _originalRepository.DeleteAsync(name, token);


    public async Task<RiskProfile> GetAsync(string name, CancellationToken token = default)
    {
        // REDIS DB GET
        RedisValue redisValue = await _redisDb.StringGetAsync(name);

        if (redisValue.IsNullOrEmpty)
        {
            RiskProfile profileFromDb =  await _originalRepository.GetAsync(name, token);

            string redisProfileJson = JsonSerializer.Serialize(profileFromDb);

            await _redisDb.StringSetAsync(name, redisProfileJson);

            return profileFromDb;
        }

        string redisProfileJsonStr = redisValue.ToString();

        RiskProfile profile = JsonSerializer.Deserialize<RiskProfile>(redisProfileJsonStr) ?? throw new InvalidOperationException();

        return profile;
    }

    public  Task<IEnumerable<RiskProfile>> QueryAsync(string query, CancellationToken token = default) =>  _originalRepository.QueryAsync(query, token);

    public Task UpdateAsync(string name, RiskProfile riskProfile, CancellationToken token = default) => _originalRepository.UpdateAsync(name, riskProfile, token);

}