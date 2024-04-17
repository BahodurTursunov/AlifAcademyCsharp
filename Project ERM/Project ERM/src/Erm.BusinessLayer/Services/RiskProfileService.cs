using AutoMapper;
using Erm.BusinessLayer;
using Erm.DataAccess;
using FluentValidation;

using Project_ERM.Erm.BusinessLayer.Mapper;
using Project_ERM.Erm.BusinessLayer.Validators;
using Project_ERM.Erm.DataAccess;

namespace Project_ERM.Erm.BusinessLayer.Services;
public sealed class RiskProfileService : IRiskProfileService
{
    private readonly IMapper _mapper;

    private readonly IValidator<RiskProfileInfo> _validationRules = new RiskProfileInfoValidator();

    private readonly RiskProfileRepositoryProxy _redisRepository;


    //public RiskProfileService(IMapper mapper, IValidator<RiskProfileInfo> validationRules, RiskProfileRepositoryProxy redisRepository)
    //{
    //    _mapper = mapper;
    //    _validationRules = validationRules;
    //    _redisRepository = redisRepository;
    //}

    public void Create(RiskProfileInfo riskProfileInfo)
    {
        _validationRules.ValidateAndThrow(riskProfileInfo);
        RiskProfile riskProfile = _mapper.Map<RiskProfile>(riskProfileInfo);
        _redisRepository.Create(riskProfile);

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

    public IEnumerable<RiskProfileInfo> Query(string query)
    {
        ArgumentException.ThrowIfNullOrEmpty(query);
        IEnumerable<RiskProfile> riskProfiles = _redisRepository.Query(query);
        return _mapper.Map<IEnumerable<RiskProfileInfo>>(riskProfiles);
    }
}

/*
 * автомапинг попытается преобразовать данные из riskprofileinfo в riskprofile, он будет обращать внимание на схожесть свойств
в данном примере наш automapper попытается смапить данные из riskprofileinfo в riskprofile 
 */