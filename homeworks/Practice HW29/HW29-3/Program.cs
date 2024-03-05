namespace HW29_3
{
    using System;
    using System.Collections;

    class Program
    {

        public static void Main(string[] args)
        {
            // Создаем Hashtable
            Hashtable hashtable = new Hashtable();

            // Добавляем элементы в Hashtable
            hashtable.Add(new Person("John", 30), "Software Engineer");
            hashtable.Add(new Person("Jane", 25), "Data Scientist");
            hashtable.Add(new Person("Peter", 40), "Manager");

            // Получаем значение по ключу
            string jobTitle = (string)hashtable[new Person("John", 30)];
            Console.WriteLine(jobTitle); // Выводит "Software Engineer"

            // Удаляем элемент из Hashtable
            hashtable.Remove(new Person("Jane", 25));

            // Проверяем, содержит ли Hashtable элемент
            bool containsPeter = hashtable.ContainsKey(new Person("Peter", 40));
            Console.WriteLine(containsPeter); // Выводит True

            hashtable.Clear();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return Name == otherPerson.Name && Age == otherPerson.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}
