namespace Project_ERM.Erm.DataAccess
{
    public class BusinessProcess
    {
        public int Id { get; set; }
        public required string Name { get; set; } // название бизнес процесса
        public required string Domain { get; set; } // область применения

        //public BusinessProcess(string name, string domain)
        //{
        //    Name = name;
        //    Domain = domain;
        //}

        //public BusinessProcess()
        //{
        //    throw new NotImplementedException();
        //}
    }

}
