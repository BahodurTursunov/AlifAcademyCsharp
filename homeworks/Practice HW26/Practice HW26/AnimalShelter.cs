using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW26
{
    internal class AnimalShelter<TAnimal> : IAnimalShelter<TAnimal> where TAnimal : Animal
    {
        private List<TAnimal> animals = new List<TAnimal>();

        public TAnimal GetAnimal()
        {
            if (animals.Any())
            {
                var animal = animals.First();
                animals.Remove(animal);
                return animal;
            }
            return null;
        }

        public void AcceptAnimal(Animal animal)
        {
            if (animal is TAnimal)
            {
                animals.Add((TAnimal)animal);
                Console.WriteLine($"Accepted {animal.GetType().Name} named {animal.Name}");
            }
            else
            {
                Console.WriteLine($"Cannot accept {animal.GetType().Name} in this shelter");
            }
        }
    }
}
