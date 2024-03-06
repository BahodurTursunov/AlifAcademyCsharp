using System.Reflection;

namespace HW31_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CacheableTypeChecker.PrintCacheableTypes();
        }
    }

    // Создание пользовательского атрибута Cacheable
    [AttributeUsage(AttributeTargets.Class)]
    public class CacheableAttribute : Attribute
    {
        public string CacheDescription { get; }

        public CacheableAttribute(string cacheDescription)
        {
            CacheDescription = cacheDescription;
        }
    }

    // Обобщенный класс Cache<T>
    public class Cache<T>
    {
        // Логика кэша
    }

    // Применение атрибута Cacheable к нескольким классам
    [Cacheable("Cacheable object for caching data in memory.")]
    public class UserData
    {
        // Логика класса UserData
    }

    [Cacheable("Cacheable object for storing configuration settings.")]
    public class ConfigurationData
    {
        // Логика класса ConfigurationData
    }

    public class CacheableTypeChecker
    {
        public static void PrintCacheableTypes()
        {
            // Получаем все сборки в текущем домене приложения
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                // Получаем все типы в сборке
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    // Проверяем, имеет ли класс атрибут Cacheable
                    var cacheableAttribute = type.GetCustomAttribute<CacheableAttribute>();

                    if (cacheableAttribute != null)
                    {
                        Console.WriteLine($"Type '{type.Name}' is cacheable: {cacheableAttribute.CacheDescription}");
                    }
                }
            }
        }
    }


}
