using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW26
{
    internal interface IAnimalShelter<out TAnimal>
    {
        TAnimal GetAnimal();

        void AcceptAnimal(Animal animal);
    }
}
