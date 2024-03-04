using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ERM.src.Erm.DataAccess
{
    public class BusinessProcess
    {
        public required string Name { get; set; } // название бизнес процесса
        public required string Domain { get; set; } // область /*применения*/
    }

}
