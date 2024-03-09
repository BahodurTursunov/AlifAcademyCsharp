using AutoMapper;

using Erm.BusinessLayer;
using Erm.BusinessLayer.Validators;
using Erm.DataAccess;

using FluentValidation;

using Project_ERM.Erm.DataAccess;

namespace Project_ERM.Erm.BusinessLayer.Services;
public sealed class RiskProfileService : IRiskProfileService
{
    private readonly IRiskProfileRepository _repository;
    private readonly IMapper _mapper;
    private readonly RiskProfileInfoValidator _validationRules;


    public RiskProfileService()
    {
        _validationRules = new();
        _repository = new RiskProfileRepository();
        _mapper = AutoMapperHelper.MapperConfiguration.CreateMapper(); // MapperConfiguration содержит информацию о классах, который он будет преобразовывать один в другой
    }

    public void Create(RiskProfileInfo profileInfo)
    {
        _validationRules.ValidateAndThrow(profileInfo);

        RiskProfile riskProfile = _mapper.Map<RiskProfile>(profileInfo);

        _repository.Create(riskProfile);
    }
}

/*
 * автомапинг попытается преобразовать данные из riskprofileinfo в riskprofile, он будет обращать внимание на схожесть свойств
в данном примере наш automapper попытается смапить данные из riskprofileinfo в riskprofile 
 */

