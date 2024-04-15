namespace Project_ERM.Erm.DataAccess
{
    public class BusinessProcess
    {
        public int Id { get; set; }
        public required string? Name { get; set; } // название бизнес процесса
        public required string? Domain { get; set; } // область применения

       public ICollection<RiskProfile>? RiskProfiles { get; set; } // данная запись указывает нам, что данный бизнес-процесс связан с множеством риск-профилей
    }

}
