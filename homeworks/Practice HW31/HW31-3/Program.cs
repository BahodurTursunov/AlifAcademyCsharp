using System.Reflection;

namespace HW31_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получение атрибутов с помощью отражения и вывод информации о них
            var userDataAttribute = typeof(UserData).GetCustomAttribute<CacheableAttribute>();
            Console.WriteLine($"UserData is cacheable: {userDataAttribute.CacheDescription}");

            var configDataAttribute = typeof(ConfigurationData).GetCustomAttribute<CacheableAttribute>();
            Console.WriteLine($"ConfigurationData is cacheable: {configDataAttribute.CacheDescription}");
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


}
