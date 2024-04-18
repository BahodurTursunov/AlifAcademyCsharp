namespace Project_ERM.Erm.DataAccess
{
    public class BusinessProcess
    {
        public int Id { get; set; }
        public required string Name { get; set; } = null!;// название бизнес процесса
        public required string Domain { get; set; } = null!; // область применения

        public ICollection<RiskProfile> RiskProfiles { get; set; } // данная запись указывает нам, что данный бизнес-процесс связан с множеством риск-профилей
    }

}