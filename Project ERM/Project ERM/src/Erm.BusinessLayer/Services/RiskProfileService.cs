using AutoMapper;

using Erm.BusinessLayer;

using FluentValidation;

using Project_ERM.Erm.BusinessLayer.Validators;
using Project_ERM.Erm.DataAccess;
using Project_ERM.Erm.DataAccess.Repositories;


namespace Project_ERM.Erm.BusinessLayer.Services;
public sealed class RiskProfileService : IRiskProfileService
{
    private readonly IRiskProfileRepository _repository;

    private readonly IMapper _mapper;

    private readonly RiskProfileInfoValidator _validationRules;

    //private readonly RiskProfileRepositoryProxy _redisRepository;


    public RiskProfileService()
    {
        _validationRules = new();
        _repository = new RiskProfileRepositoryProxy(new RiskProfileRepository());
        _mapper = AutoMapperHelper.MapperConfiguration.CreateMapper();
    }

    public async Task CreateAsync(RiskProfileInfo riskProfileInfo, CancellationToken token = default)
    {
        await _validationRules.ValidateAndThrowAsync(riskProfileInfo, token);
        RiskProfile riskProfile = _mapper.Map<RiskProfile>(riskProfileInfo);
        await _repository.CreateAsync(riskProfile, token);

        #region MyRegion
        /*//RiskProfileInfoValidator validationRules = new();
               //ValidationResult result = validationRules.Validate(profileInfo);
               //if (!result.IsValid)
               //{
               //    foreach (ValidationFailure failure in result.Errors)
               //    {
               //        Debug.WriteLine(failure.ErrorMessage);
               //    }
               //}
               //_validationRules.ValidateAndThrow(profileInfo);
               //RiskProfile riskProfile = _mapper.Map<RiskProfile>(profileInfo);
               //_repository.Create(riskProfile);*/
        #endregion
    }

    public async Task<RiskProfileInfo> GetAsync(string name, CancellationToken token = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        return _mapper.Map<RiskProfileInfo>(await _repository.GetAsync(name, token));
    }

    public async Task<IEnumerable<RiskProfileInfo>> QueryAsync(string query, CancellationToken token = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(query);
        return _mapper.Map<IEnumerable<RiskProfileInfo>>(await _repository.QueryAsync(query, token));
    }
}

/*
 * автомапинг попытается преобразовать данные из riskprofileinfo в riskprofile, он будет обращать внимание на схожесть свойств
в данном примере наш automapper попытается смапить данные из riskprofileinfo в riskprofile 
 */