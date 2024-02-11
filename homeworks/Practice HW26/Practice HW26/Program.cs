namespace Practice_HW26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание приюта для кошек
            IAnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();

            // добавление кошки в приют
            catShelter.AcceptAnimal(new Cat { Name = "Whiskey" });

            //получение животного из приюта и использование ковариации
            Animal animal = catShelter.GetAnimal();
            Console.WriteLine($"Got {animal.GetType().Name} named {animal.Name}");
            animal.MakeSound();

            // создание приюта для животных и использование контрвариантности
            IAnimalShelter<Animal> animalShelter = new AnimalShelter<Cat>();

            // Добавление собаки в приют
            animalShelter.AcceptAnimal(new Dog { Name = "Buddy" });

            //получение собаки из приюта
            Animal dog = animalShelter.GetAnimal();
            Console.WriteLine($"Got {dog.GetType().Name} named {dog.Name}");
            dog.MakeSound();
        }
    }
}
