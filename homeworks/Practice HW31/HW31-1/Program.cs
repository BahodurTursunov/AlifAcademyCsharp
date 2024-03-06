namespace HW31_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получение атрибутов с помощью отражения
            var classAAttributes = typeof(ClassA).GetCustomAttributes(typeof(LoggerAttribute), true);
            var classBAttributes = typeof(ClassB).GetCustomAttributes(typeof(LoggerAttribute), true);

            // Вывод информации о регистраторах для каждого класса
            foreach (LoggerAttribute attribute in classAAttributes)
            {
                Console.WriteLine($"Logger for ClassA: {attribute.LoggerName}");
            }

            foreach (LoggerAttribute attribute in classBAttributes)
            {
                Console.WriteLine($"Logger for ClassB: {attribute.LoggerName}");
            }
        }
    }


    [AttributeUsage(AttributeTargets.Class)]
    public class LoggerAttribute : Attribute
    {
        public string LoggerName { get; }

        public LoggerAttribute(string loggerName)
        {
            LoggerName = loggerName;
        }
    }

    // Применение атрибута Logger к нескольким классам
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
}


