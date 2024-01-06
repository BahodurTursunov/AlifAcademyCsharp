using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW12._2
{
    public partial class Person
    {
        partial void LogName(string name)
        {
            Console.WriteLine($"Logging: {name}");
        }
    }
}
