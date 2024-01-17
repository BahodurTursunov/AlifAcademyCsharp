/*
 1.  Создайте иерархию классов для представления различных типов животных, таких как "Собака", "Кошка" и "Птица".
Используйте наследование для создания производных классов от базового класса "Животное".
Добавьте в базовый класс виртуальный метод "IssueSound", который будет переопределяться в производных классах
для описания звуков, издаваемых каждым видом животных. Создайте объекты разных классов и вызовите метод "MakeSound"
для каждого из них через базовый класс.
 */
namespace Practice_HW19
{
    internal class Cat : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Cat(string name, int age, string color)
        {
            Console.WriteLine($"{name}, {age}, {color}");
        }

        public override void IssueSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
