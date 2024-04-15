using AutoMapper;

using Erm.DataAccess;
using FluentValidation;

using Project_ERM.Erm.BusinessLayer.Validators;
using Project_ERM.Erm.DataAccess;
using Project_ERM.Erm.DataAccess.Repositories;
namespace Project_ERM.Erm.BusinessLayer.Services;
public sealed class RiskProfileService(
    IValidator<RiskProfileInfo> validator,
    RiskProfileRepositoryProxy profileRepositoryProxy,
    IMapper mapper) : IRiskProfileService
{
    private readonly IMapper _mapper = mapper;
    private readonly IValidator<RiskProfileInfo> _validationRules = validator;
    private readonly RiskProfileRepositoryProxy _repository = profileRepositoryProxy;
    public void Create(RiskProfileInfo riskProfileInfo)
    {
        _validationRules.ValidateAndThrow(riskProfileInfo);
        RiskProfile riskProfile = _mapper.Map<RiskProfile>(riskProfileInfo);
        _repository.Create(riskProfile);

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
        IEnumerable<RiskProfile> riskProfiles = _repository.Query(query);
        return _mapper.Map<IEnumerable<RiskProfileInfo>>(riskProfiles);
    }
}

/*
 * автомапинг попытается преобразовать данные из riskprofileinfo в riskprofile, он будет обращать внимание на схожесть свойств
в данном примере наш automapper попытается смапить данные из riskprofileinfo в riskprofile 
 */

