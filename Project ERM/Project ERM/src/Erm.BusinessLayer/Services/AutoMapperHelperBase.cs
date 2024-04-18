using AutoMapper;

using Project_ERM.Erm.BusinessLayer.Mapper;

namespace Project_ERM.Erm.BusinessLayer.Services
{
    internal static class AutoMapperHelper
    {
        //internal readonly static MapperConfiguration MapperConfiguration = new(opt => { opt.CreateMap<RiskProfileInfo, RiskProfile>(); }); // к примеру здесь он создает информацию о маппинге RiskProfileInfo в RiskProfile
        //// сделали мы его readonly static для того, чтобы он был доступен во всей сборке

        //// чтобы использоваться автомаппер, мы должны создать configuration, зачем он нужен? он нужен нам чтобы он мог преобразовывать один к другому. 
        internal readonly static MapperConfiguration MapperConfiguration = new(opt => opt.AddProfile<RiskProfileInfoProfile>());
    }
}