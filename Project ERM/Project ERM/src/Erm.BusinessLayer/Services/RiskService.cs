//using Erm.BusinessLayer.Validators;
//using FluentValidation;
//using Erm.DataAccess;
//using AutoMapper;

//namespace Erm.BusinessLayer;

//public sealed class RiskService : IRiskService
//{
//    private readonly IRiskRepository _riskRepository;
//    private readonly IMapper _mapper;
//    private readonly RiskInfoValidator _validationRules;
//    public RiskService()
//    {
//        _riskRepository = new RiskRepository();
//        _mapper = AutoMapper.MapperConfiguration.CreateMapper();
//        _validationRules = new();
//    }

//    public Risk Get(string riskName)
//    {
//        return _riskRepository.Get(riskName);
//    }

//    public void Create(RiskInfo riskInfo)
//    {
//        _validationRules.ValidateAndThrow(riskInfo);

//        Risk risk = _mapper.Map<Risk>(riskInfo);

//        _riskRepository.Create(risk);
//    }

//    public void Update(string riskName, RiskInfo riskInfo)
//    {
//        RiskInfoValidator validatorRules = new();
//        validatorRules.ValidateAndThrow(riskInfo);

//        _riskRepository.Update(riskName, new Risk
//        {
//            Name = riskInfo.Name,
//            Description = riskInfo.Description,
//            OccurrenceProbability = riskInfo.OccurrenceProbability,
//            PotentialBusinessImpact = riskInfo.PotentialBusinessImpact,
//            Type = Enum.Parse<RiskType>(riskInfo.Type)
//        });
//    }

//    public void Delete(string riskName)
//    {
//        _riskRepository.Delete(riskName);
//    }
//}