using System.Text.Json;

using Project_ERM.Erm.DataAccess;

using StackExchange.Redis;

namespace Erm.DataAccess;

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

    public void Create(RiskProfile entity) => _originalRepository.Create(entity); // TODO: SET realisation in here

    public void Delete(string name) => _originalRepository.Delete(name);


    public RiskProfile Get(string name)
    {
        // REDIS DB GET
        RedisValue redisValue = _redisDb.StringGet(name);

        if (redisValue.IsNullOrEmpty)
            return _originalRepository.Get(name);

        string redisProfileJsonStr = redisValue.ToString();
        RiskProfile profile = JsonSerializer.Deserialize<RiskProfile>(redisProfileJsonStr) ?? throw new InvalidOperationException;
        return profile;
    }
   
    public IEnumerable<RiskProfile> Query(string query) => _originalRepository.Query(query);

    public void Update(string name, RiskProfile riskProfile) => _originalRepository.Update(name, riskProfile);

}
