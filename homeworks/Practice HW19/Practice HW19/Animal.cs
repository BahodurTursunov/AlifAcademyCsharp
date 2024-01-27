﻿/*
 1.  Создайте иерархию классов для представления различных типов животных, таких как "Собака", "Кошка" и "Птица".
Используйте наследование для создания производных классов от базового класса "Животное".
Добавьте в базовый класс виртуальный метод "IssueSound", который будет переопределяться в производных классах
для описания звуков, издаваемых каждым видом животных. Создайте объекты разных классов и вызовите метод "MakeSound"
для каждого из них через базовый класс.
 */
namespace Practice_HW19
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public virtual void IssueSound(){}

        public void MakeSound()
        {
            IssueSound();
        }
    }
}