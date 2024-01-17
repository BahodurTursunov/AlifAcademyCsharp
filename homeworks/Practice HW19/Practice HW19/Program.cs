/*
 1.  Создайте иерархию классов для представления различных типов животных, таких как "Собака", "Кошка" и "Птица".
Используйте наследование для создания производных классов от базового класса "Животное".
Добавьте в базовый класс виртуальный метод "IssueSound", который будет переопределяться в производных классах
для описания звуков, издаваемых каждым видом животных. Создайте объекты разных классов и вызовите метод "MakeSound"
для каждого из них через базовый класс.
 */
namespace Practice_HW19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new("Kitty", 2, "gray");
            cat.MakeSound();

            Console.WriteLine();

            Bird bird = new("Jack", 1, "red");
            bird.MakeSound();

            Console.WriteLine();

            Dog dog = new("Max", 5, "black");
            dog.MakeSound();
        }
    }
}
