using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW12
{
    public partial class Person
    {
        public string LastName { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
