using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW26
{
    internal class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }
}
