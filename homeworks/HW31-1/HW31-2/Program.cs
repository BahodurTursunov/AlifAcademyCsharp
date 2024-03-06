using System.Reflection;

namespace HW31_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerChecker.PrintClassLoggers();
        }
    }

    public class LoggerAttribute : Attribute
    {
        public string LoggerName { get; }

        public LoggerAttribute(string loggerName)
        {
            LoggerName = loggerName;
        }
    }

    [Logger("ClassA Logger")]
    public class ClassA
    {
        // Логика класса ClassA
    }

    [Logger("ClassB Logger")]
    public class ClassB
    {
        // Логика класса ClassB
    }

    public class LoggerChecker
    {
        public static void PrintClassLoggers()
        {
            // Получаем все сборки в текущем домене приложения
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                // Получаем все типы в сборке
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    // Проверяем, имеет ли класс атрибут Logger
                    var loggerAttribute = type.GetCustomAttribute<LoggerAttribute>();

                    if (loggerAttribute != null)
                    {
                        Console.WriteLine($"Class '{type.Name}' is associated with '{loggerAttribute.LoggerName}' logger.");
                    }
                }
            }
        }
    }



}
